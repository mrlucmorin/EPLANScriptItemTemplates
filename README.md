# EPLANScriptItemTemplates
Visual Studio Item templates to create EPLAN scripts

To build, simply run the zipFolber.bat script.

Place the resulting zip files in your Visual Studio personal templates folder, for example:

C:\Users<YOUR_USERNAME>\Documents\Visual Studio 2015\Templates\ItemTemplates\Visual C#\EPLAN

After restarting Visual Studio, the new Item template will be available.

##Template types

There are 3 types of templates provided:

###Run Scripts

Those arer scripts that do not add an `Action` to EPLAN, but rather are meant to be ran on demand. They are not loaded in memory, and will be called by the EPLAN *Utilities > Scripts > Run...* menu, or from a toolbar button with the `ExecuteScript` action:

`ExecuteScript /ScriptFile:"C:\Users\Public\EPLAN\Data\Scripts\ABC\SwitchUnits.cs"`

###Loaded Scripts

Those are scripts that must be loaded in EPLAN, and must define an `Action`. The defined action can then be called just as any built-in EPLAN action, typicall through a toolbar button, and simply calling the action name.

###Load Scripts with menu

Those scripts are like loaded scripts, except that they also define an entry in the EPLAN menu system, allowing to call the action.
