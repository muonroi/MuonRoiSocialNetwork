using BaseConfig.EntityObject.Entity;
using BaseConfig.MethodResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using MuonRoiSocialNetwork.Common.Models.Users;
using System.Threading.Tasks;
using MuonRoiSocialNetwork.Application.Commands.Users;
using MuonRoiSocialNetwork.Application.Commands.Email;

namespace MuonRoiSocialNetwork.Controllers
{
    /// <summary>
    /// Auth: PhiLe 20230305
    /// </summary>
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        /// <summary>
        /// Constructure
        /// </summary>
        /// <param name="mediator"></param>
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Register new user API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(MethodResult<UserModel>), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(VoidMethodResult), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> RegisterUser([FromBody] CreateUserCommand cmd)
        {
            try
            {
                MethodResult<UserModel> methodResult = await _mediator.Send(cmd).ConfigureAwait(false);
                return methodResult.GetActionResult();
            }
            catch (Exception ex)
            {
                var errCommandResult = new VoidMethodResult();
                errCommandResult.AddErrorMessage(Helpers.GetExceptionMessage(ex), ex.StackTrace ?? "");
                return errCommandResult.GetActionResult();
            }
        }
        /// <summary>
        /// Login API
        /// </summary>
        /// <returns></returns>
        [HttpPost("auth")]
        [ProducesResponseType(typeof(MethodResult<UserModel>), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(VoidMethodResult), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> LoginAuth([FromBody] AuthUserCommand cmd)
        {
            try
            {
                MethodResult<UserModel> methodResult = await _mediator.Send(cmd).ConfigureAwait(false);
                return methodResult.GetActionResult();
            }
            catch (Exception ex)
            {
                var errCommandResult = new VoidMethodResult();
                errCommandResult.AddErrorMessage(Helpers.GetExceptionMessage(ex), ex.StackTrace ?? "");
                return errCommandResult.GetActionResult();
            }
        }
        /// <summary>
        /// Verification email
        /// </summary>
        /// <returns></returns>
        [HttpPatch("VerificationEmail/{uid}/{token}")]
        [ProducesResponseType(typeof(MethodResult<bool>), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(VoidMethodResult), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> VerificationEmail([FromRoute] Guid uid, string token)
        {
            try
            {
                VerificationEmailCommand cmd = new()
                {
                    UserGuid = uid,
                    TokenJWT = token
                };
                MethodResult<bool> methodResult = await _mediator.Send(cmd).ConfigureAwait(false);
                return methodResult.GetActionResult();
            }
            catch (Exception ex)
            {
                var errCommandResult = new VoidMethodResult();
                errCommandResult.AddErrorMessage(Helpers.GetExceptionMessage(ex), ex.StackTrace ?? "");
                return errCommandResult.GetActionResult();
            }
        }
    }
}
