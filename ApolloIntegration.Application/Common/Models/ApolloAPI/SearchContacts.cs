using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ApolloIntegration.Application.Common.Models.ApolloAPI
{

    public partial class SearchContacts
    {
        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("breadcrumbs")]
        public Breadcrumb[] Breadcrumbs { get; set; }

        [JsonProperty("partial_results_only")]
        public bool PartialResultsOnly { get; set; }

        [JsonProperty("disable_eu_prospecting")]
        public bool DisableEuProspecting { get; set; }

        [JsonProperty("partial_results_limit")]
        public long PartialResultsLimit { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("num_fetch_result")]
        public object NumFetchResult { get; set; }
    }

    public partial class Breadcrumb
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("signal_field_name")]
        public string SignalFieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("linkedin_url")]
        public Uri LinkedinUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contact_stage_id")]
        public string ContactStageId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("person_id")]
        public string PersonId { get; set; }

        [JsonProperty("email_needs_tickling")]
        public bool EmailNeedsTickling { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("original_source")]
        public string OriginalSource { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("photo_url")]
        public Uri PhotoUrl { get; set; }

        [JsonProperty("present_raw_address")]
        public string PresentRawAddress { get; set; }

        [JsonProperty("linkedin_uid")]
        public object LinkedinUid { get; set; }

        [JsonProperty("extrapolated_email_confidence")]
        public object ExtrapolatedEmailConfidence { get; set; }

        [JsonProperty("salesforce_id")]
        public object SalesforceId { get; set; }

        [JsonProperty("salesforce_lead_id")]
        public object SalesforceLeadId { get; set; }

        [JsonProperty("salesforce_contact_id")]
        public object SalesforceContactId { get; set; }

        [JsonProperty("salesforce_account_id")]
        public object SalesforceAccountId { get; set; }

        [JsonProperty("crm_owner_id")]
        public object CrmOwnerId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("emailer_campaign_ids")]
        public object[] EmailerCampaignIds { get; set; }

        [JsonProperty("direct_dial_status")]
        public object DirectDialStatus { get; set; }

        [JsonProperty("direct_dial_enrichment_failed_at")]
        public object DirectDialEnrichmentFailedAt { get; set; }

        [JsonProperty("email_status")]
        public string EmailStatus { get; set; }

        [JsonProperty("email_source")]
        public string EmailSource { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("last_activity_date")]
        public object LastActivityDate { get; set; }

        [JsonProperty("hubspot_vid")]
        public object HubspotVid { get; set; }

        [JsonProperty("hubspot_company_id")]
        public object HubspotCompanyId { get; set; }

        [JsonProperty("sanitized_phone")]
        public object SanitizedPhone { get; set; }

        [JsonProperty("merged_crm_ids")]
        public object MergedCrmIds { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("queued_for_crm_push")]
        public object QueuedForCrmPush { get; set; }

        [JsonProperty("suggested_from_rule_engine_config_id")]
        public object SuggestedFromRuleEngineConfigId { get; set; }

        [JsonProperty("email_unsubscribed")]
        public object EmailUnsubscribed { get; set; }

        [JsonProperty("label_ids")]
        public string[] LabelIds { get; set; }

        [JsonProperty("has_pending_email_arcgate_request")]
        public bool HasPendingEmailArcgateRequest { get; set; }

        [JsonProperty("has_email_arcgate_request")]
        public bool HasEmailArcgateRequest { get; set; }

        [JsonProperty("existence_level")]
        public string ExistenceLevel { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_from_customer")]
        public object EmailFromCustomer { get; set; }

        [JsonProperty("typed_custom_fields")]
        public TypedCustomFields TypedCustomFields { get; set; }

        [JsonProperty("contact_campaign_statuses")]
        public object[] ContactCampaignStatuses { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("contact_emails")]
        public object[] ContactEmails { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("phone_numbers")]
        public object[] PhoneNumbers { get; set; }

        [JsonProperty("account_phone_note")]
        public object AccountPhoneNote { get; set; }

        [JsonProperty("free_domain")]
        public bool FreeDomain { get; set; }

        [JsonProperty("contact_job_change_event")]
        public object ContactJobChangeEvent { get; set; }
    }

    public partial class Account
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website_url")]
        public Uri WebsiteUrl { get; set; }

        [JsonProperty("blog_url")]
        public object BlogUrl { get; set; }

        [JsonProperty("angellist_url")]
        public object AngellistUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public Uri LinkedinUrl { get; set; }

        [JsonProperty("twitter_url")]
        public Uri TwitterUrl { get; set; }

        [JsonProperty("facebook_url")]
        public object FacebookUrl { get; set; }

        [JsonProperty("primary_phone")]
        public TypedCustomFields PrimaryPhone { get; set; }

        [JsonProperty("languages")]
        public object[] Languages { get; set; }

        [JsonProperty("alexa_ranking")]
        public object AlexaRanking { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("linkedin_uid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long LinkedinUid { get; set; }

        [JsonProperty("founded_year")]
        public object FoundedYear { get; set; }

        [JsonProperty("publicly_traded_symbol")]
        public object PubliclyTradedSymbol { get; set; }

        [JsonProperty("publicly_traded_exchange")]
        public object PubliclyTradedExchange { get; set; }

        [JsonProperty("logo_url")]
        public Uri LogoUrl { get; set; }

        [JsonProperty("crunchbase_url")]
        public object CrunchbaseUrl { get; set; }

        [JsonProperty("primary_domain")]
        public string PrimaryDomain { get; set; }

        [JsonProperty("persona_counts")]
        public TypedCustomFields PersonaCounts { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("account_stage_id")]
        public string AccountStageId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("original_source")]
        public string OriginalSource { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("phone_status")]
        public string PhoneStatus { get; set; }

        [JsonProperty("hubspot_id")]
        public object HubspotId { get; set; }

        [JsonProperty("salesforce_id")]
        public object SalesforceId { get; set; }

        [JsonProperty("crm_owner_id")]
        public object CrmOwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public object ParentAccountId { get; set; }

        [JsonProperty("account_playbook_statuses")]
        public object[] AccountPlaybookStatuses { get; set; }

        [JsonProperty("existence_level")]
        public string ExistenceLevel { get; set; }

        [JsonProperty("label_ids")]
        public object[] LabelIds { get; set; }

        [JsonProperty("typed_custom_fields")]
        public TypedCustomFields TypedCustomFields { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }
    }

    public partial class TypedCustomFields
    {
    }

    public partial class Organization
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website_url")]
        public Uri WebsiteUrl { get; set; }

        [JsonProperty("blog_url")]
        public object BlogUrl { get; set; }

        [JsonProperty("angellist_url")]
        public object AngellistUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public Uri LinkedinUrl { get; set; }

        [JsonProperty("twitter_url")]
        public Uri TwitterUrl { get; set; }

        [JsonProperty("facebook_url")]
        public object FacebookUrl { get; set; }

        [JsonProperty("primary_phone")]
        public TypedCustomFields PrimaryPhone { get; set; }

        [JsonProperty("languages")]
        public object[] Languages { get; set; }

        [JsonProperty("alexa_ranking")]
        public object AlexaRanking { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("linkedin_uid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long LinkedinUid { get; set; }

        [JsonProperty("founded_year")]
        public object FoundedYear { get; set; }

        [JsonProperty("publicly_traded_symbol")]
        public object PubliclyTradedSymbol { get; set; }

        [JsonProperty("publicly_traded_exchange")]
        public object PubliclyTradedExchange { get; set; }

        [JsonProperty("logo_url")]
        public Uri LogoUrl { get; set; }

        [JsonProperty("crunchbase_url")]
        public object CrunchbaseUrl { get; set; }

        [JsonProperty("primary_domain")]
        public string PrimaryDomain { get; set; }

        [JsonProperty("persona_counts")]
        public TypedCustomFields PersonaCounts { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_entries")]
        public long TotalEntries { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }
    }

    public partial class SearchContacts
    {
        public static SearchContacts FromJson(string json) => JsonConvert.DeserializeObject<SearchContacts>(json, ApolloIntegration.Application.Common.Models.ApolloAPI.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SearchContacts self) => JsonConvert.SerializeObject(self, ApolloIntegration.Application.Common.Models.ApolloAPI.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
