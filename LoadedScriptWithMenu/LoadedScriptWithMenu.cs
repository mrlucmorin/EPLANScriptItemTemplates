/*
Luc Morin (MRN), EPLAN Software and Services, December 2015

Sample script, API training example
*/


/*
The following compiler directive is necessary to enable editing scripts
within Visual Studio.

It requires that the "Conditional compilation symbol" SCRIPTENV be defined 
in the Visual Studio project properties

This is because EPLAN's internal scripting engine already adds "using directives"
when you load the script in EPLAN. Having them twice would cause errors.
*/

#if SCRIPTENV
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;
using Eplan.EplApi.Gui;
#endif

/*
On the other hand, some namespaces are not automatically added by EPLAN when
you load a script. Those have to be outside of the previous conditional compiler directive
*/

using System.Windows.Forms;
using System.IO;

namespace $rootnamespace$
{

    class $safeitemname$
    {
        [DeclareAction("$safeitemname$Action")]
        public void SampleMethod()
        {
            MessageBox.Show("Hello from loaded script with menu!", "Sample loaded script with menu");

        }

        [DeclareMenu]
        public void MenuMethod()
        {
            Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
            oMenu.AddMenuItem("Sample Action Menu Text", "$safeitemname$Action");
        }
    }
}
