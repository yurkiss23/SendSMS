using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMS.Models
{
    public partial class MessagesInfoModel
    {
        public int Code { get; set; }
        public List<DataRequest> Data { get; set; }
        public string Message { get; set; }
    }

    public partial class DataRequest
    {
        public string[] Items { get; set; }
        public int TotalItemCount { get; set; }
    }

    public partial class ListMes
    {
        public object ContentProviderName { get; set; }

        //[JsonProperty("partnerId")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long PartnerId { get; set; }

        //[JsonProperty("userId")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long UserId { get; set; }

        //[JsonProperty("usedStopListWords")]
        public object UsedStopListWords { get; set; }

        //[JsonProperty("countryA2")]
        public object CountryA2 { get; set; }

        //[JsonProperty("operatorName")]
        public object OperatorName { get; set; }

        //[JsonProperty("id")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        //[JsonProperty("campaignId")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long CampaignId { get; set; }

        //[JsonProperty("segNum")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long SegNum { get; set; }

        //[JsonProperty("segUserBuy")]
        public string SegUserBuy { get; set; }

        //[JsonProperty("status")]
        public string Status { get; set; }

        //[JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        //[JsonProperty("from")]
        public string From { get; set; }

        //[JsonProperty("to")]
        public string To { get; set; }

        //[JsonProperty("groups")]
        public object Groups { get; set; }

        //[JsonProperty("text")]
        public string Text { get; set; }

        //[JsonProperty("startSendTs")]
        public DateTimeOffset StartSendTs { get; set; }

        //[JsonProperty("statusUpdateTs")]
        public DateTimeOffset StatusUpdateTs { get; set; }

        //[JsonProperty("contactCardId")]
        public object ContactCardId { get; set; }

        //[JsonProperty("contentProviderId")]
        public object ContentProviderId { get; set; }

        //[JsonProperty("segPartnerSell")]
        public object SegPartnerSell { get; set; }

        //[JsonProperty("segPartnerBuy")]
        public object SegPartnerBuy { get; set; }

        //[JsonProperty("segSystemSell")]
        public object SegSystemSell { get; set; }

        //[JsonProperty("segSystemBuy")]
        public object SegSystemBuy { get; set; }

        //[JsonProperty("systemCurrency")]
        public object SystemCurrency { get; set; }

        //[JsonProperty("campaign")]
        //public Campaign Campaign { get; set; }
    }

    //public partial class Campaign
    //{
    //    //[JsonProperty("usedStopListWords")]
    //    public object UsedStopListWords { get; set; }

    //    //[JsonProperty("highlightedText")]
    //    public object HighlightedText { get; set; }

    //    //[JsonProperty("isTemplateComment")]
    //    public object IsTemplateComment { get; set; }

    //    //[JsonProperty("moderationStatus")]
    //    public string ModerationStatus { get; set; }

    //    //[JsonProperty("commonStatus")]
    //    public string CommonStatus { get; set; }

    //    //[JsonProperty("currency")]
    //    public object Currency { get; set; }

    //    //[JsonProperty("ids")]
    //    public object Ids { get; set; }

    //    //[JsonProperty("groupsList")]
    //    public List<object> GroupsList { get; set; }

    //    //[JsonProperty("id")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long Id { get; set; }

    //    //[JsonProperty("userId")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long UserId { get; set; }

    //    //[JsonProperty("partnerId")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long PartnerId { get; set; }

    //    //[JsonProperty("partnerModeratorId")]
    //    public object PartnerModeratorId { get; set; }

    //    //[JsonProperty("globalModeratorId")]
    //    public object GlobalModeratorId { get; set; }

    //    //[JsonProperty("type")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long Type { get; set; }

    //    //[JsonProperty("recipientsSource")]
    //    public object RecipientsSource { get; set; }

    //    //[JsonProperty("msgType")]
    //    public string MsgType { get; set; }

    //    //[JsonProperty("rateLimit")]
    //    public object RateLimit { get; set; }

    //    //[JsonProperty("ratePeriod")]
    //    public object RatePeriod { get; set; }

    //    //[JsonProperty("partnerModStatus")]
    //    public string PartnerModStatus { get; set; }

    //    //[JsonProperty("globalModStatus")]
    //    public string GlobalModStatus { get; set; }

    //    //[JsonProperty("sendStatus")]
    //    public string SendStatus { get; set; }

    //    //[JsonProperty("creationWay")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long CreationWay { get; set; }

    //    //[JsonProperty("isDeleted")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long IsDeleted { get; set; }

    //    //[JsonProperty("deferredToTs")]
    //    public object DeferredToTs { get; set; }

    //    //[JsonProperty("createTs")]
    //    public DateTimeOffset CreateTs { get; set; }

    //    //[JsonProperty("startSendTs")]
    //    public DateTimeOffset StartSendTs { get; set; }

    //    //[JsonProperty("endSendTs")]
    //    public DateTimeOffset EndSendTs { get; set; }

    //    //[JsonProperty("expirationTs")]
    //    public DateTimeOffset ExpirationTs { get; set; }

    //    //[JsonProperty("name")]
    //    public object Name { get; set; }

    //    //[JsonProperty("from")]
    //    public string From { get; set; }

    //    //[JsonProperty("text")]
    //    public string Text { get; set; }

    //    //[JsonProperty("extra")]
    //    public Extra Extra { get; set; }

    //    //[JsonProperty("groups")]
    //    public object Groups { get; set; }

    //    //[JsonProperty("globalComment")]
    //    public object GlobalComment { get; set; }
    //}

    //public partial class Extra
    //{
    //    //[JsonProperty("validity")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long Validity { get; set; }

    //    //[JsonProperty("mclass")]
    //    public object Mclass { get; set; }

    //    //[JsonProperty("isTestAlphanameUsed")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long IsTestAlphanameUsed { get; set; }

    //    //[JsonProperty("coding")]
    //    //[JsonConverter(typeof(ParseStringConverter))]
    //    public long Coding { get; set; }

    //    //[JsonProperty("charset")]
    //    public string Charset { get; set; }

    //    //[JsonProperty("trackShortLinkRecipients")]
    //    public long TrackShortLinkRecipients { get; set; }
    //}
}
