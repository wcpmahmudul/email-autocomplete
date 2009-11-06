using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvAutocompleteExample
{
    public partial class ExampleForm : Form
    {
        // Name conditioning is:
        //      "FirstName LastName" <email@domain.com>
        // or this is also okay:
        //      "LastName, FirstName <email@domain.com>
        // Email address only is (quotes and angle brackets optional):
        //      email@domain.com
        //      "email@domain.com"
        private string[] EmailAutocompleteDataSet = 
        {
            "\"Jo Robbins\" <jorobbins@gmail.com>",
            "\"Jeffrey Bronson\" <jeffreybronz@gmail.com>",
            "\"Branson, John\" <john.branson@gmail.com>",
            "\"James Sawyer\" <jammies.soy@gmail.com>",
            "\"John Sawyer\" <jon.soy@gmail.com>",
            "\"Jeff Bridges\" <jbridges@gmail.com>",
            "\"Jeffrey Brigades\" <jeff.brig@gmail.com>",
            "\"Jemmmmmmmini Boggles\" <jboggs@gmail.com>",
            "\"Jiiiiiiiiiiiiiiii Boondocks\" <jboons@gmail.com>",
            "\"JB Promi\" <jb.promo@gmail.com>",
            "\"J Benjamins\" <benjamins@gmail.com>",
            "\"Jasperannagannemans Benjaminshin\" <this.guy@gmail.com>",
            "\"J Beener\" <playerpiano@gmail.com>",
            "\"J Beenstick\" <aksyouaquestion@hotmail.com>",
            "\"J Benz\" <abcdefg@hotmail.com>",
            "\"J Bonkers\" <godzilla@yahoo.com>",
            "\"J Bankers\" <bankers@yahoo.com>",
            "\"J Bacon\" <jbacon@yahoo.com>",
            "\"K Bacon\" <kbacon@yahoo.com>",
            "\"Bacon Bros.\" <baconbros@yahoo.com>",
            "judyinithica@hotmail.com",
            "justaholst@hotmail.com",
            "jeometryking@hotmail.com",
            "james.dean@hotmail.com",
            "jimmy.dean@yahoo.com",
            "jalapeno.scott@gmail.com",
            "\"Jeffrey Rush\" <rush.man@gmail.com>",
        };

        public ExampleForm()
        {
            InitializeComponent();

            tbEmailAutocomplete.EmailAutocompleteSource = EmailAutocompleteDataSet;
        }
    }
}