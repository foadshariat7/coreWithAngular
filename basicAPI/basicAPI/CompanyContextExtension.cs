using basicAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI
{
    public static class CompanyContextExtension
    {
        public static void EnsureSeedDataForContext(this CompanyContext context)
        {
            if (context.Companies.Any())
            {
                return;
            }

            var companies = new List<Company>()
            {
                new Company()
                {
                    Name = "Microsoft",
                    Description =
                        "Microsoft Corporation is an American multinational technology company with headquarters in Redmond, Washington.",
                    Founded = new DateTime(1975, 4, 4),
                    Technologies = new List<Technology>()
                    {
                        new Technology()
                        {
                            Name = "C#",
                            Description =
                                "a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.",
                            Appeared = new DateTime(2000, 1, 1)
                        },
                        new Technology()
                        {
                            Name = "Typescript",
                            Description =
                                "It is a strict syntactical superset of JavaScript, and adds optional static typing to the language. ",
                            Appeared = new DateTime(2012, 1, 1)
                        },
                        new Technology()
                        {
                            Name = "F#",
                            Description =
                                "a strongly typed, multi-paradigm programming language that encompasses functional, imperative, and object-oriented programming methods.",
                            Appeared = new DateTime(2005, 1, 1)
                        }
                    }
                },
                new Company()
                {
                    Name = "Apple",
                    Description =
                        "Apple Inc. is an American multinational technology company headquartered in Cupertino, California that designs, develops, and sells consumer electronics, computer software, and online services.",
                    Founded = new DateTime(1976, 4, 1),
                    Technologies = new List<Technology>()
                    {
                        new Technology()
                        {
                            Name = "Objective-c",
                            Description =
                                "It was the main programming language used by Apple for the OS X and iOS operating systems, and their respective application programming interfaces (APIs) Cocoa and Cocoa Touch prior to the introduction of Swift.",
                            Appeared = new DateTime(1984, 1, 1)
                        },
                        new Technology()
                        {
                            Name = "Swift",
                            Description =
                                "Swift is designed to work with Apple\'s Cocoa and Cocoa Touch frameworks and the large body of existing Objective-C (ObjC) code written for Apple products.",
                            Appeared = new DateTime(2014, 1, 1)
                        }
                    }
                }
            };
            context.Companies.AddRange(companies);
            context.SaveChanges();
        }
    }
}
