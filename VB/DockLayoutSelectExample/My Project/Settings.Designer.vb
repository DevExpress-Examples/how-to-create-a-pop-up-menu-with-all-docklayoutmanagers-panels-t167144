﻿' Developer Express Code Central Example:
' How to create a pop-up menu with all DockLayoutManager's panels
' 
' This example demonstrates how to create a pop-up menu with all
' DockLayoutManager's panels, which show the current active state of each
' panel.
' For this, we create a BarManager with a BarSubItem. After that, we
' subscribe to the BarSubItem's Popup event. When Popup is raised, we get a list
' of all DockLayoutManager's panels. We iterate through this list and add this
' BarCheckItem to the BarSubItem with a respective panel as a tag. We check the
' DockLayoutSource's ActiveLayoutItem. If the ActiveLayoutItem equals a panel from
' the list, we set the BarCheckItem's IsChecked property to True. Then, we
' subscribe to the BarCheckItem's CheckedChanged event. When CheckedChanged is
' raised, we get a panel from a current BarCheckItem's tag and activate this
' panel.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T167144

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace
