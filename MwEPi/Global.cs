using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MwEPi
{

    public class Global
    {
        /// <summary>
        /// Group names for content types and properties
        /// </summary>
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Contact_", Order = 1)]
            public const string _Contact = "Contact_";

            [Display(Name = "Default_", Order = 2)]
            public const string _Default = "Default_";

            [Display(Name = "Metadata_", Order = 3)]
            public const string _MetaData = "Metadata_";

            [Display(Name = "News_", Order = 4)]
            public const string _News = "News_";

            [Display(Name = "Products_", Order = 5)]
            public const string _Products = "Products_";

            [Display(Name = "SiteSettings_", Order = 6)]
            public const string _SiteSettings = "SiteSettings_";

            [Display(Name = "Specialized_", Order = 7)]
            public const string _Specialized = "Specialized_";
        }

        /// <summary>
        /// Tags to use for the main widths used in the Bootstrap HTML framework
        /// </summary>
        public static class ContentAreaTags
        {
            public const string FullWidth = "span12";
            public const string TwoThirdsWidth = "span8";
            public const string HalfWidth = "span6";
            public const string OneThirdWidth = "span4";
            public const string NoRenderer = "norenderer";
        }

        /// <summary>
        /// Main widths used in the Bootstrap HTML framework
        /// </summary>
        public static class ContentAreaWidths
        {
            public const int FullWidth = 12;
            public const int TwoThirdsWidth = 8;
            public const int HalfWidth = 6;
            public const int OneThirdWidth = 4;
        }

        public static Dictionary<string, int> ContentAreaTagWidths = new Dictionary<string, int>
            {
                { ContentAreaTags.FullWidth, ContentAreaWidths.FullWidth },
                { ContentAreaTags.TwoThirdsWidth, ContentAreaWidths.TwoThirdsWidth },
                { ContentAreaTags.HalfWidth, ContentAreaWidths.HalfWidth },
                { ContentAreaTags.OneThirdWidth, ContentAreaWidths.OneThirdWidth }
            };

        /// <summary>
        /// Names used for UIHint attributes to map specific rendering controls to page properties
        /// </summary>
        public static class SiteUIHints
        {
            public const string Contact = "contact";
            public const string Strings = "StringList";
        }

        /// <summary>
        /// Virtual path to folder with static graphics, such as "~/Static/gfx/"
        /// </summary>
        public const string StaticGraphicsFolderPath = "~/Static/gfx/";
    }
}

