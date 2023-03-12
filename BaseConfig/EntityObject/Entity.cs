using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MediatR;
using MongoDB.Bson.Serialization.Attributes;
using BaseConfig.Extentions;

namespace BaseConfig.EntityObject.Entity
{
    public class Entity : ValidationObject
    {
        private int? _requestedHashCode;

        private List<INotification> _domainEvents;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [BsonId]
        public virtual int Id { get; set; }

        public Guid Guid { get; set; }

        public int SiteId { get; set; }

        [Column(Order = 101)]
        [Required(AllowEmptyStrings = true)]
        public int? CreatedUserId { get; set; }

        [Column(Order = 102)]
        public int? UpdatedUserId { get; set; }

        [Column(Order = 103)]
        public int? DeletedUserId { get; set; }

        [Column(Order = 104)]
        [MaxLength(100)]
        public string CreatedUserName { get; set; }

        [Column(Order = 105)]
        [MaxLength(100)]
        public string? UpdatedUserName { get; set; }

        [Column(Order = 106)]
        [MaxLength(100)]
        public string? DeletedUserName { get; set; }

        [Column(Order = 107)]
        public double CreatedDateTS { get; set; }

        [Column(Order = 108)]
        public double? UpdatedDateTS { get; set; }

        [Column(Order = 109)]
        public double? DeletedDateTS { get; set; }

        [Column(Order = 110)]
        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        protected Entity()
        {
            DateTime utcNow = DateTime.UtcNow;
            CreatedDateTS = utcNow.GetTimeStamp(includedTimeValue: true);
            Id = 0;
        }

        public void AddDomainEvent(INotification eventItem)
        {
            _domainEvents = _domainEvents ?? new List<INotification>();
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(INotification eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public bool IsTransient()
        {
            return Id == 0;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
            {
                return false;
            }

            if (this == obj)
            {
                return true;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            Entity entity = (Entity)obj;
            if (entity.IsTransient() || IsTransient())
            {
                return false;
            }

            return entity.Id == Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                {
                    _requestedHashCode = Id.GetHashCode() ^ 0x1F;
                }

                return _requestedHashCode.Value;
            }

            return base.GetHashCode();
        }
    }
}
