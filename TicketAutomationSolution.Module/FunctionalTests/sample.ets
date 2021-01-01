;#DropDB TicketAutomationSolutionEasyTest

#Application TicketAutomationSolutionWin
#Application TicketAutomationSolutionWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef TicketAutomationSolutionWin

*Action About...
 
*Action OK

#EndIf

#IfDef TicketAutomationSolutionWeb
*Action Navigation(My Details)
#EndIf
