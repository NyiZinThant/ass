Dim mealPlanChoice as String
Dim numAdults as integer
Dim numChildren as Integer
Dim regularCost as integer
Dim weightlifter as integer
Dim enduranceCost as integer
Dim GFregularCost as integer
Dim GFweightlifterCost as integer
Dim GFendurance as integer
Dim VregularCost as integer
Dim VweightlifterCost as integer
Dim VenduranceCost as integer
Dim regularChildCost as integer
Dim GFregularChildCost as integer
Dim VregularChildCost as integer
Dim muscleFitnessCost as integer
Dim enduranceFitnessCost as integer
Dim balancedFitnessCost as integer

regularCost = 50
weightlifterCost = 50
enduranceCost = 55
GFregularCost = 45
GFenduranceCost = 45
GFweightlifterCost = 50
VregularCost = 40
VweightlifterCost = 50
VenduranceCost = 45
regularChildCost = 40
GFregularChildCost = 35
VregularChildCost = 30
muscleFitnessCost = 40
enduranceFitnessCost = 40
balancedFitnessCost = 30

cmdDetails.Enable = False

Private Sub cmdMealplan_Click(sender As Object, e As EventArgs) Handles cmdMealplan.Click
    mealPlanChoice = cboMealplan.selectedItem
    if(mealPlanChoice = "Regular healthy eating plan" Or "Glute free healthy eating plan" Or "Vegetarian healthy eating plan")
        cboNumChildren.Enable = True
    Else 
        cboNumChildren.Enable = False
    End If
    cboMealplan.Enable = False
End Sub

Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
    Dim totalCost as Integer
    Dim fitnessPlansCost as Integer
    Dim output as String
    Dim fitnessPlans as String

    numChildren = cboNumChildren.selectedItem
    numAdutls = cboNumAdults.selectedItem

    output = output & "Meal plan chosen: " & mealPlanChoice & vbCrlf
    if(mealPlanChoice = "Regular healthy eating plan") Then
        totalCost = (regularChildCost * numChildren) = (regularCost * numAdults)
        output = output & "Cost per adult: $" & regularCost & " Number of adults " & numAdults & vbCrlf & " Cost per children " & regularChildCost & " Number of children " & numChildren & vbCrlf & " Total cost" & totalCost
    Else if (mealPlanChoice = "Glute free healthy eating plan") Then
        totalCost = (GFregularChildCost * numChildren) = (GFregularCost * numAdults)
        output = output & "Cost per adult: $" & GFregularCost & " Number of adults " & numAdults & vbCrlf & " Cost per children " & GFregularChildCost & " Number of children " & numChildren & vbCrlf & " Total cost" & totalCost
    Else if (mealPlanChoice = "Vegetarian healthy eating plan") Then
        totalCost = (VregularChildCost * numChildren) = (VregularCost * numAdults)
        output = output & "Cost per adult: $" & VregularCost & " Number of adults " & numAdults & vbCrlf & " Cost per children " & VregularChildCost & " Number of children " & numChildren & vbCrlf & " Total cost" & totalCost
    Else if (mealPlanChoice = "Weightlifter eating plan") Then
        totalCost = weightlifterCost * numAdults
        output = output & “ Cost per adult: $” & weightlifterCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    Else if (mealPlanChoice = "Endurance trainer eating plan") Then
        totalCost = enduranceCost * numAdults
        output = output & “ Cost per adult: $” & enduranceCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    Else if (mealPlanChoice = "Gluten free weightlifter eating plan") Then
        totalCost = GFweightlifterCost * numAdults
        output = output & “ Cost per adult: $” & GFweightlifterCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    Else if (mealPlanChoice = "Gluten free endurance trainer eating plan") Then
        totalCost = GFenduranceCost * numAdults
        output = output & “ Cost per adult: $” & GFenduranceCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    Else if (mealPlanChoice = "Vegetarian weightlifter eating plan") Then
        totalCost = VweightlifterCost * numAdults
        output = output & “ Cost per adult: $” & VweightlifterCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    Else if (mealPlanChoice = "Vegetarian Endurance trainer eating plan") Then
        totalCost = VenduranceCost * numAdults
        output = output & “ Cost per adult: $” & VenduranceCost &  “ Number of adults “ &  numAdults & vbCrlf & “ Total cost“ & totalCost
    End If

    If (chkMuscle.Checked = True) Then
        fitnessPlansCost = fitnessPlansCost + muscleFitnessCost
        fitnessPlans =  fitnessPlans & vbCrlf & "Muscle building fitness plan." & “Cost $ “ & muscleFitnessCost
    EndIF
    If (chkEndurance.Checked = True) Then
        fitnessPlansCost = fitnessPlansCost + enduranceFitnessCost
        fitnessPlans =  fitnessPlans & vbCrlf & “Endurance building fitness plan.” & “Cost $ “ & muscleFitnessCost
    EndIF
    If (chkBalanced.Checked = True) Then
        fitnessPlansCost = fitnessPlansCost + enduranceFitnessCost
        fitnessPlans =  fitnessPlans & vbCrlf & "Balanced fitness plan." & “Cost $ “ & muscleFitnessCost
    EndIF
    totalCost = totalCost + fitnessPlansCost
    output = output & vbCrlf & “You chose the following plans: “ & fitnessPlans & vbCrlf & “The total cost of your subscription is: $” & totalCost
    lblOutput.text = output
    cmdSubmit.Enable = False
    cmdDetails.Enable = True
End Sub

Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
    Dim name, address as String
    Dim ccNum as Integer

    Do
        name = inputBox("Please enter your name")
    Loop While(name = "")
    Do
        address = inputBox("Please enter your name")
    Loop While(address = "")
    Do
        ccNum = inputBox("Please enter your name")
    Loop While(ccNum.length <> 16)

    MsgBox("Thank you, your subscription is set up")
    Application.Exit();
End Sub

