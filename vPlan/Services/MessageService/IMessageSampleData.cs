using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vPlan.Services.MessageService
{
    /// <summary>
    /// Test data för meddelande hantering och visning.
    /// </summary>
    public partial class MessageService
    {
        IEnumerable<Models.Message> vPlanTestData()
        {
            var froms = new[]
            {
                "Lenny Pedersen",
                "Nisse Nilsson",
                "Denna Härsson",
                "Vemvet Intejagson",
                "Jack Jackie",
                "Blopp Blipp",
                "Spock Jabba",
                "Administrator",
                "Management",
                "Teamleader"
            };

            var subjects = new[]
            {
                "Do that thing!",
                "Personalrapport",
                "Uppdatering av Arbetsplatser",
                "Korrigera scheman i tid!!",
                "Bla blagdish",
                "Nya funktioner",
                "Ajabaja moster maja!",
                "Träffas?",
                "Intranät",
                "BugTester...."
            };

            var bodys = new[]
            {
                "Variables don't; constants aren't.",
                "The bogosity meter just pegged.",
                "First study the enemy. Seek weakness",
                "Uncontrolled power will turn even saints into savages. And we can all be counted on to live down to our lowest impulses",
                "If you can't convince them, confuse them.",
                "Do Lipton Tea employees take coffee breaks?",
                "Oh, so there you are! ",
                "Hackers of the world, unite! ",
                "fortune: No such file or directory",
                "Those who can't write, write manuals."
            };

            for(int i = 0; i < 10; i++)
            {
                var message = new Models.Message
                {
                    mId = Guid.NewGuid().ToString(),
                    mDate = DateTime.Now.Subtract(TimeSpan.FromDays(_random.Next(0, 10))),
                    mSubject = subjects[i],
                    mBody = bodys[i],
                    mFrom = froms[i],
                    mTo = "vPlan Dev"
                };

                yield return message;
            }
        }
    }
}
