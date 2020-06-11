using System;
namespace DotNetAdvancedUtilities.LanguageComponentPattern.Core
{
    [Serializable]
    public class LanguageComponentManager : IDisposable
    {
        public LanguageComponentTrackMark TrackMark;
        public Object Parameter;
        public int Index;
        public LanguageComponent FirstLanguage;
        public void Run()
        {
            FirstLanguage.Run(this);
        }
        public void Resume()
        {
            if (TrackMark != null)
            {
                (TrackMark.GetInvocationList()[Index] as LanguageComponentTrackMark)(Parameter,this);
            }
        }

        public void Dispose()
        {
            if (this.TrackMark == null)
            {
                this.FirstLanguage = null;
                this.Parameter = null;
            }
            LanguageComponentManagerFactory.FreeLanguageComponentObject(this);
        }
    }
}