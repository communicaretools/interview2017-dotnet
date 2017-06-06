using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PasReg.Model
{
    public class StudyRegistry
    {
        private readonly Study[] studies;
        
        public StudyRegistry()
        {
            studies = new []
            {
                new Study
                {
                    Id = Guid.Parse("8A773720-D2A1-4D30-B2B2-7C822FD29AAA"), 
                    Name = "Stressmestring", 
                    Groups = new [] { "App", "Pilot", "Kontroll" }
                },
                new Study
                {
                    Id = Guid.Parse("69BDA4C1-A4FE-4E68-907D-2EE2DED85EDC"), 
                    Name = "eSupport", 
                    Groups = new [] { "Full intervensjon", "Kun spørsmål og svar", "Kontroll" }
                },
                new Study
                {
                    Id = Guid.Parse("34618A7E-E0D5-438C-96FE-5BA2BD4BFC9F"), 
                    Name = "Revma styrke", 
                    Groups = new [] { "App", "Kurs", "Pilot", "Kontroll" }
                },
            };
        }

        public Study[] GetAll()
        {
            return studies;
        }

        public Study GetOne(Guid id)
        {
            return studies.Single(s => s.Id == id);
        }
    }
}