using System.Collections.Generic;

namespace ApocalypseLauncherApi.API.v0
{
    public class Language
    {
        public string LanguegeSet { get; set; }
        public List<string> LanguageAvailable { get; set; }
    }

    public class Theme
    {
        public string ThemeSet { get; set; }
        public List<string> ThemeAvailable { get; set; }
    }

    public class Style
    {
        public string StyleSet { get; set; }
        public List<string> StyleAvailable { get; set; }
    }

    public class Launcher
    {
        public Language Language { get; set; }
        public Theme Theme { get; set; }
        public Style Style { get; set; }
        public bool HideMeWhenGameStart { get; set; }
        public bool CheckForUpdatesOnStartup { get; set; }
    }


    // ReSharper disable once InconsistentNaming
    public class en_nUs
    {
        public string TextSet { get; set; }
        public string VoiceSet { get; set; }
        public List<string> TextAvailable { get; set; }
        public List<string> VoiceAvailable { get; set; }
    }

    // ReSharper disable once InconsistentNaming
    public class ru_Ru
    {
        public string TextSet { get; set; }
        public string VoiceSet { get; set; }
        public List<string> TextAvailable { get; set; }
        public List<string> VoiceAvailable { get; set; }
    }

    public class LanguageAvailable
    {
        // ReSharper disable once InconsistentNaming
        public en_nUs EnNUs { get; set; } 
        // ReSharper disable once InconsistentNaming
        public ru_Ru ru_RU { get; set; }
    }

    public class LanguageGame
    {
        public string LanguageSet { get; set; }
        public LanguageAvailable LanguageAvailable { get; set; }
    }

    public class ClientDll
    {
        public string ClientDllSet { get; set; }
        public List<string> ClientDllAvailable { get; set; }
    }

    public class Game
    {
        public LanguageGame Language { get; set; }
        public ClientDll ClientDll { get; set; }
    }

    public class Settings
    {
        public Launcher Launcher { get; set; }
        public Game Game { get; set; }
    }

    public partial class RootObject
    {

        // ReSharper disable once InconsistentNaming
        public string version { get; set; }

        // ReSharper disable once InconsistentNaming
        public int api { get; set; }

        // ReSharper disable once InconsistentNaming
        public Settings settings { get; set; }
    } 
}