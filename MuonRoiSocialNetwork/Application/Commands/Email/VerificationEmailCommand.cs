using AutoMapper;
using BaseConfig.EntityObject.Entity;
using BaseConfig.MethodResult;
using MuonRoi.Social_Network.Users;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using MuonRoiSocialNetwork.Application.Commands.Base;
using MuonRoiSocialNetwork.Common.Settings.Appsettings;
using MuonRoiSocialNetwork.Domains.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace MuonRoiSocialNetwork.Application.Commands.Email
{
    /// <summary>
    /// Verification email
    /// </summary>
    public class VerificationEmailCommand : IRequest<MethodResult<bool>>
    {
        /// <summary>
        /// Guid user active
        /// </summary>
        public Guid UserGuid { get; set; }
        /// <summary>
        /// Token active
        /// </summary>
        public string? TokenJWT { get; set; }

    }
    /// <summary>
    /// Handle command class
    /// </summary>
    public class VerificationEmailCommandHandler : BaseCommandHandler, IRequestHandler<VerificationEmailCommand, MethodResult<bool>>
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="configuration"></param>
        /// <param name="userRepository"></param>
        public VerificationEmailCommandHandler(IMapper mapper,
            IConfiguration configuration, IUserRepository userRepository) : base(mapper, configuration)
        {
            _userRepository = userRepository;
        }
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<MethodResult<bool>> Handle(VerificationEmailCommand request, CancellationToken cancellationToken)
        {
            MethodResult<bool> methodResult = new();
            try
            {
                AppUser checkUser = await _userRepository.GetByGuidAsync(request.UserGuid);
                if (checkUser == null)
                {
                    methodResult.StatusCode = StatusCodes.Status400BadRequest;
                    methodResult.AddApiErrorMessage(
                        nameof(EnumUserErrorCodes.USR02C),
                        new[] { Helpers.GenerateErrorResult(nameof(request.UserGuid), request.UserGuid) }
                    );
                    return methodResult;
                }
                var symmetricKey = new SymmetricSecurityKey(Convert.FromBase64String(_configuration.GetSection(ConstAppSettings.APPLICATIONSERECT).Value));
                var tokenHandler = new JwtSecurityTokenHandler();
                var myIssuer = _configuration.GetSection(ConstAppSettings.APPLICATIONENVCONNECTION).Value;
                var myAudience = _configuration.GetSection(ConstAppSettings.APPLICATIONAPPDOMAIN).Value;
                try
                {
                    tokenHandler.ValidateToken(request.TokenJWT, new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidIssuer = myIssuer,
                        ValidAudience = myAudience,
                        IssuerSigningKey = symmetricKey
                    }, out SecurityToken validatedToken);
                }
                catch
                {
                    methodResult.Result = false;
                    methodResult.StatusCode = StatusCodes.Status400BadRequest;
                    methodResult.AddApiErrorMessage(
                        nameof(EnumUserErrorCodes.USRC36C),
                        new[] { Helpers.GenerateErrorResult(nameof(request.TokenJWT), request.TokenJWT ?? "") }
                    );
                    return methodResult;
                }
                checkUser.EmailConfirmed = true;
                checkUser.Status = EnumAccountStatus.Confirmed;
                if (await _userRepository.ConfirmedEmail(checkUser) == -1)
                {
                    methodResult.Result = false;
                    methodResult.StatusCode = StatusCodes.Status400BadRequest;
                    methodResult.AddApiErrorMessage(
                        nameof(EnumUserErrorCodes.USRC37C),
                        new[] { Helpers.GenerateErrorResult(nameof(checkUser.UserName), checkUser.UserName ?? "") }
                    );
                    return methodResult;
                }
                methodResult.Result = true;
                methodResult.StatusCode = StatusCodes.Status200OK;
                return methodResult;
            }
            catch (Exception ex)
            {

                methodResult.StatusCode = StatusCodes.Status400BadRequest;
                methodResult.AddApiErrorMessage(
                    nameof(EnumUserErrorCodes.USR29C),
                    new[] { Helpers.GenerateErrorResult(nameof(ex.Message), ex.Message) }
                );
                return methodResult;
            }
        }
    }
}
