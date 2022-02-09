// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MicrosoftStemmingTokenizerLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MicrosoftStemmingTokenizerLanguage
    {
        [EnumMember(Value = "arabic")]
        Arabic,
        [EnumMember(Value = "bangla")]
        Bangla,
        [EnumMember(Value = "bulgarian")]
        Bulgarian,
        [EnumMember(Value = "catalan")]
        Catalan,
        [EnumMember(Value = "croatian")]
        Croatian,
        [EnumMember(Value = "czech")]
        Czech,
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "estonian")]
        Estonian,
        [EnumMember(Value = "finnish")]
        Finnish,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "greek")]
        Greek,
        [EnumMember(Value = "gujarati")]
        Gujarati,
        [EnumMember(Value = "hebrew")]
        Hebrew,
        [EnumMember(Value = "hindi")]
        Hindi,
        [EnumMember(Value = "hungarian")]
        Hungarian,
        [EnumMember(Value = "icelandic")]
        Icelandic,
        [EnumMember(Value = "indonesian")]
        Indonesian,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "kannada")]
        Kannada,
        [EnumMember(Value = "latvian")]
        Latvian,
        [EnumMember(Value = "lithuanian")]
        Lithuanian,
        [EnumMember(Value = "malay")]
        Malay,
        [EnumMember(Value = "malayalam")]
        Malayalam,
        [EnumMember(Value = "marathi")]
        Marathi,
        [EnumMember(Value = "norwegianBokmaal")]
        NorwegianBokmaal,
        [EnumMember(Value = "polish")]
        Polish,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "portugueseBrazilian")]
        PortugueseBrazilian,
        [EnumMember(Value = "punjabi")]
        Punjabi,
        [EnumMember(Value = "romanian")]
        Romanian,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "serbianCyrillic")]
        SerbianCyrillic,
        [EnumMember(Value = "serbianLatin")]
        SerbianLatin,
        [EnumMember(Value = "slovak")]
        Slovak,
        [EnumMember(Value = "slovenian")]
        Slovenian,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "swedish")]
        Swedish,
        [EnumMember(Value = "tamil")]
        Tamil,
        [EnumMember(Value = "telugu")]
        Telugu,
        [EnumMember(Value = "turkish")]
        Turkish,
        [EnumMember(Value = "ukrainian")]
        Ukrainian,
        [EnumMember(Value = "urdu")]
        Urdu
    }
    internal static class MicrosoftStemmingTokenizerLanguageEnumExtension
    {
        internal static string ToSerializedValue(this MicrosoftStemmingTokenizerLanguage? value)
        {
            return value == null ? null : ((MicrosoftStemmingTokenizerLanguage)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MicrosoftStemmingTokenizerLanguage value)
        {
            switch( value )
            {
                case MicrosoftStemmingTokenizerLanguage.Arabic:
                    return "arabic";
                case MicrosoftStemmingTokenizerLanguage.Bangla:
                    return "bangla";
                case MicrosoftStemmingTokenizerLanguage.Bulgarian:
                    return "bulgarian";
                case MicrosoftStemmingTokenizerLanguage.Catalan:
                    return "catalan";
                case MicrosoftStemmingTokenizerLanguage.Croatian:
                    return "croatian";
                case MicrosoftStemmingTokenizerLanguage.Czech:
                    return "czech";
                case MicrosoftStemmingTokenizerLanguage.Danish:
                    return "danish";
                case MicrosoftStemmingTokenizerLanguage.Dutch:
                    return "dutch";
                case MicrosoftStemmingTokenizerLanguage.English:
                    return "english";
                case MicrosoftStemmingTokenizerLanguage.Estonian:
                    return "estonian";
                case MicrosoftStemmingTokenizerLanguage.Finnish:
                    return "finnish";
                case MicrosoftStemmingTokenizerLanguage.French:
                    return "french";
                case MicrosoftStemmingTokenizerLanguage.German:
                    return "german";
                case MicrosoftStemmingTokenizerLanguage.Greek:
                    return "greek";
                case MicrosoftStemmingTokenizerLanguage.Gujarati:
                    return "gujarati";
                case MicrosoftStemmingTokenizerLanguage.Hebrew:
                    return "hebrew";
                case MicrosoftStemmingTokenizerLanguage.Hindi:
                    return "hindi";
                case MicrosoftStemmingTokenizerLanguage.Hungarian:
                    return "hungarian";
                case MicrosoftStemmingTokenizerLanguage.Icelandic:
                    return "icelandic";
                case MicrosoftStemmingTokenizerLanguage.Indonesian:
                    return "indonesian";
                case MicrosoftStemmingTokenizerLanguage.Italian:
                    return "italian";
                case MicrosoftStemmingTokenizerLanguage.Kannada:
                    return "kannada";
                case MicrosoftStemmingTokenizerLanguage.Latvian:
                    return "latvian";
                case MicrosoftStemmingTokenizerLanguage.Lithuanian:
                    return "lithuanian";
                case MicrosoftStemmingTokenizerLanguage.Malay:
                    return "malay";
                case MicrosoftStemmingTokenizerLanguage.Malayalam:
                    return "malayalam";
                case MicrosoftStemmingTokenizerLanguage.Marathi:
                    return "marathi";
                case MicrosoftStemmingTokenizerLanguage.NorwegianBokmaal:
                    return "norwegianBokmaal";
                case MicrosoftStemmingTokenizerLanguage.Polish:
                    return "polish";
                case MicrosoftStemmingTokenizerLanguage.Portuguese:
                    return "portuguese";
                case MicrosoftStemmingTokenizerLanguage.PortugueseBrazilian:
                    return "portugueseBrazilian";
                case MicrosoftStemmingTokenizerLanguage.Punjabi:
                    return "punjabi";
                case MicrosoftStemmingTokenizerLanguage.Romanian:
                    return "romanian";
                case MicrosoftStemmingTokenizerLanguage.Russian:
                    return "russian";
                case MicrosoftStemmingTokenizerLanguage.SerbianCyrillic:
                    return "serbianCyrillic";
                case MicrosoftStemmingTokenizerLanguage.SerbianLatin:
                    return "serbianLatin";
                case MicrosoftStemmingTokenizerLanguage.Slovak:
                    return "slovak";
                case MicrosoftStemmingTokenizerLanguage.Slovenian:
                    return "slovenian";
                case MicrosoftStemmingTokenizerLanguage.Spanish:
                    return "spanish";
                case MicrosoftStemmingTokenizerLanguage.Swedish:
                    return "swedish";
                case MicrosoftStemmingTokenizerLanguage.Tamil:
                    return "tamil";
                case MicrosoftStemmingTokenizerLanguage.Telugu:
                    return "telugu";
                case MicrosoftStemmingTokenizerLanguage.Turkish:
                    return "turkish";
                case MicrosoftStemmingTokenizerLanguage.Ukrainian:
                    return "ukrainian";
                case MicrosoftStemmingTokenizerLanguage.Urdu:
                    return "urdu";
            }
            return null;
        }

        internal static MicrosoftStemmingTokenizerLanguage? ParseMicrosoftStemmingTokenizerLanguage(this string value)
        {
            switch( value )
            {
                case "arabic":
                    return MicrosoftStemmingTokenizerLanguage.Arabic;
                case "bangla":
                    return MicrosoftStemmingTokenizerLanguage.Bangla;
                case "bulgarian":
                    return MicrosoftStemmingTokenizerLanguage.Bulgarian;
                case "catalan":
                    return MicrosoftStemmingTokenizerLanguage.Catalan;
                case "croatian":
                    return MicrosoftStemmingTokenizerLanguage.Croatian;
                case "czech":
                    return MicrosoftStemmingTokenizerLanguage.Czech;
                case "danish":
                    return MicrosoftStemmingTokenizerLanguage.Danish;
                case "dutch":
                    return MicrosoftStemmingTokenizerLanguage.Dutch;
                case "english":
                    return MicrosoftStemmingTokenizerLanguage.English;
                case "estonian":
                    return MicrosoftStemmingTokenizerLanguage.Estonian;
                case "finnish":
                    return MicrosoftStemmingTokenizerLanguage.Finnish;
                case "french":
                    return MicrosoftStemmingTokenizerLanguage.French;
                case "german":
                    return MicrosoftStemmingTokenizerLanguage.German;
                case "greek":
                    return MicrosoftStemmingTokenizerLanguage.Greek;
                case "gujarati":
                    return MicrosoftStemmingTokenizerLanguage.Gujarati;
                case "hebrew":
                    return MicrosoftStemmingTokenizerLanguage.Hebrew;
                case "hindi":
                    return MicrosoftStemmingTokenizerLanguage.Hindi;
                case "hungarian":
                    return MicrosoftStemmingTokenizerLanguage.Hungarian;
                case "icelandic":
                    return MicrosoftStemmingTokenizerLanguage.Icelandic;
                case "indonesian":
                    return MicrosoftStemmingTokenizerLanguage.Indonesian;
                case "italian":
                    return MicrosoftStemmingTokenizerLanguage.Italian;
                case "kannada":
                    return MicrosoftStemmingTokenizerLanguage.Kannada;
                case "latvian":
                    return MicrosoftStemmingTokenizerLanguage.Latvian;
                case "lithuanian":
                    return MicrosoftStemmingTokenizerLanguage.Lithuanian;
                case "malay":
                    return MicrosoftStemmingTokenizerLanguage.Malay;
                case "malayalam":
                    return MicrosoftStemmingTokenizerLanguage.Malayalam;
                case "marathi":
                    return MicrosoftStemmingTokenizerLanguage.Marathi;
                case "norwegianBokmaal":
                    return MicrosoftStemmingTokenizerLanguage.NorwegianBokmaal;
                case "polish":
                    return MicrosoftStemmingTokenizerLanguage.Polish;
                case "portuguese":
                    return MicrosoftStemmingTokenizerLanguage.Portuguese;
                case "portugueseBrazilian":
                    return MicrosoftStemmingTokenizerLanguage.PortugueseBrazilian;
                case "punjabi":
                    return MicrosoftStemmingTokenizerLanguage.Punjabi;
                case "romanian":
                    return MicrosoftStemmingTokenizerLanguage.Romanian;
                case "russian":
                    return MicrosoftStemmingTokenizerLanguage.Russian;
                case "serbianCyrillic":
                    return MicrosoftStemmingTokenizerLanguage.SerbianCyrillic;
                case "serbianLatin":
                    return MicrosoftStemmingTokenizerLanguage.SerbianLatin;
                case "slovak":
                    return MicrosoftStemmingTokenizerLanguage.Slovak;
                case "slovenian":
                    return MicrosoftStemmingTokenizerLanguage.Slovenian;
                case "spanish":
                    return MicrosoftStemmingTokenizerLanguage.Spanish;
                case "swedish":
                    return MicrosoftStemmingTokenizerLanguage.Swedish;
                case "tamil":
                    return MicrosoftStemmingTokenizerLanguage.Tamil;
                case "telugu":
                    return MicrosoftStemmingTokenizerLanguage.Telugu;
                case "turkish":
                    return MicrosoftStemmingTokenizerLanguage.Turkish;
                case "ukrainian":
                    return MicrosoftStemmingTokenizerLanguage.Ukrainian;
                case "urdu":
                    return MicrosoftStemmingTokenizerLanguage.Urdu;
            }
            return null;
        }
    }
}
