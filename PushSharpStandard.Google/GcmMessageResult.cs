using System.Text.Json.Serialization;

namespace PushSharpStandard.Google
{
    public class GcmMessageResult
    {
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }

        [JsonPropertyName("registration_id")]
        public string CanonicalRegistrationId { get; set; }

        [JsonIgnore]
        public GcmResponseStatus ResponseStatus { get; set; }

        [JsonPropertyName("error")]
        public string Error
        {
            get
            {
                switch (ResponseStatus)
                {
                    case GcmResponseStatus.Ok:
                        return null;
                    case GcmResponseStatus.Unavailable:
                        return "Unavailable";
                    case GcmResponseStatus.QuotaExceeded:
                        return "QuotaExceeded";
                    case GcmResponseStatus.NotRegistered:
                        return "NotRegistered";
                    case GcmResponseStatus.MissingRegistrationId:
                        return "MissingRegistration";
                    case GcmResponseStatus.MissingCollapseKey:
                        return "MissingCollapseKey";
                    case GcmResponseStatus.MismatchSenderId:
                        return "MismatchSenderId";
                    case GcmResponseStatus.MessageTooBig:
                        return "MessageTooBig";
                    case GcmResponseStatus.InvalidTtl:
                        return "InvalidTtl";
                    case GcmResponseStatus.InvalidRegistration:
                        return "InvalidRegistration";
                    case GcmResponseStatus.InvalidDataKey:
                        return "InvalidDataKey";
                    case GcmResponseStatus.InternalServerError:
                        return "InternalServerError";
                    case GcmResponseStatus.DeviceQuotaExceeded:
                        return null;
                    case GcmResponseStatus.CanonicalRegistrationId:
                        return null;
                    case GcmResponseStatus.Error:
                        return "Error";
                    default:
                        return null;
                }
            }
        }
    }
}
