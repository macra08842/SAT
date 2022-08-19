Public Class Manage

    Dim nameListP(0) As String
    Dim plantTypeP(0) As String
    Dim currentEntryP As String
    Dim plantNumberP(0)
    Dim NumOfChangeP As Integer
    Dim clientName(0) As String
    Dim plantTypeC(0) As String
    Dim plantNameC(0) As String
    Dim currentEntryC As String
    Dim plantNumberC(0)
    Dim NumOfChangeC As Integer
    Dim pathPlants As String = "E:\Back-upSAT\SAT\SATPartB\PlantData.csv"
    Dim pathClients As String = "E:\Back-upSAT\SAT\SATPartB\ClientData.csv"

    'reading the plants CSV
    Function ReadPCSV()
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(pathPlants)

                'Define the Necessary Variables:
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()
                Dim listBoxEntry As String
                lbxPlantD.Items.Clear()

                'Loop Through Each Row:
                While Not MyReader.EndOfData
                    row = MyReader.ReadFields()
                    'Loop Through Each Cell:
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 1
                                If rowTicker = nameListP.Length Then
                                    ReDim Preserve nameListP(UBound(nameListP) + 1)
                                End If
                                nameListP(rowTicker) = cell
                                listBoxEntry += cell
                            Case 2
                                If rowTicker = plantTypeP.Length Then
                                    ReDim Preserve plantTypeP(UBound(plantTypeP) + 1)
                                    plantTypeP(UBound(plantTypeP)) = cell
                                Else
                                    plantTypeP(rowTicker) = cell
                                End If
                                listBoxEntry += ": " & cell
                            Case 3
                                If rowTicker = plantNumberP.Length Then
                                    ReDim Preserve plantNumberP(UBound(plantNumberP) + 1)
                                    plantNumberP(UBound(plantNumberP)) = cell
                                Else
                                    plantNumberP(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                                lbxPlantD.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    lbxPlantD.Text = "There are no current plant entries." & vbNewLine & "Add entries to the CSV to get started."
                Else
                    lbxPlantD.Text = "There are" & (rowTicker - 1) & "plants logged in this CSV."
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    Function ReadCCSV()
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(pathClients)

                'Define the Necessary Variables:
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()
                Dim listBoxEntry As String
                lbxClientD.Items.Clear()

                'Loop Through Each Row:
                While Not MyReader.EndOfData
                    row = MyReader.ReadFields()
                    'Loop Through Each Cell:
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 1
                                If rowTicker = clientName.Length Then
                                    ReDim Preserve clientName(UBound(clientName) + 1)
                                End If
                                clientName(rowTicker) = cell
                                listBoxEntry += cell
                            Case 2
                                If rowTicker = plantTypeC.Length Then
                                    ReDim Preserve plantTypeC(UBound(plantTypeC) + 1)
                                    plantTypeC(UBound(plantTypeC)) = cell
                                Else
                                    plantTypeC(rowTicker) = cell
                                End If
                                listBoxEntry += ": " & cell
                            Case 3
                                If rowTicker = plantNumberC.Length Then
                                    ReDim Preserve plantNumberC(UBound(plantNumberC) + 1)
                                    plantNumberC(UBound(plantNumberC)) = cell
                                Else
                                    plantNumberC(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                            Case 4
                                If rowTicker = plantNameC.Length Then
                                    ReDim Preserve plantNameC(UBound(plantNameC) + 1)
                                    plantNameC(UBound(plantNameC)) = cell
                                Else
                                    plantNumberC(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                                lbxClientD.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    lbxClientD.Text = "There are no current plant entries." & vbNewLine & "Add entries to the CSV to get started."
                Else
                    lbxClientD.Text = "There are" & (rowTicker - 1) & "plants logged in this CSV."
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    'send back to homepage
    Private Sub btnBackM_Click(sender As Object, e As EventArgs) Handles btnBackM.Click

        Me.Hide()
        HomePage.Show()

    End Sub

    'send to plantdata page to search
    Private Sub lblSearchPlant_Click(sender As Object, e As EventArgs) Handles lblSearchPlant.Click

        Me.Hide()
        PlantData.Show()

    End Sub

    Private Sub btnPSort_Click(sender As Object, e As EventArgs) Handles btnPSort.Click

        'SORT plants CSV BUTTON

        ReadPCSV()
        Dim tempSortArray(1)
        Dim rowTicker As Integer = 0
        For Each plant In nameListP
            If rowTicker > 0 Then
                ReDim Preserve tempSortArray(tempSortArray.Length)
            End If
            rowTicker += 1
            tempSortArray(rowTicker) = plant
        Next
        rowTicker = 0
        For Each element In plantTypeP
            rowTicker += 1
            tempSortArray(rowTicker) += "," & element
        Next
        rowTicker = 0
        For Each element In plantNumberP
            rowTicker += 1
            tempSortArray(rowTicker) += "," & element
        Next
        Array.Sort(tempSortArray, 2, tempSortArray.Length - 2)
        My.Computer.FileSystem.WriteAllText(pathPlants, Join(tempSortArray, vbNewLine), False)
        ReadPCSV()


    End Sub

    Private Sub btnSearchC_Click(sender As Object, e As EventArgs) Handles btnSearchC.Click

        Me.Hide()
        Client_Data.Show()

    End Sub

    Private Sub btnSortC_Click(sender As Object, e As EventArgs) Handles btnSortC.Click

        'SORT clients CSV BUTTON
        ReadCCSV()
        Dim tempSortArray(1)
        Dim rowTicker As Integer = 0
        For Each client In clientName
            If rowTicker > 0 Then
                ReDim Preserve tempSortArray(tempSortArray.Length)
            End If
            rowTicker += 1
            tempSortArray(rowTicker) = client
        Next
        rowTicker = 0
        For Each order In plantNameC
            rowTicker += 1
            tempSortArray(rowTicker) += "," & order
        Next
        rowTicker = 0
        For Each order In plantTypeC
            rowTicker += 1
            tempSortArray(rowTicker) += "," & order
        Next
        rowTicker = 0
        For Each order In plantNumberC
            rowTicker += 1
            tempSortArray(rowTicker) += "," & order
        Next
        Array.Sort(tempSortArray, 2, tempSortArray.Length - 2)
        My.Computer.FileSystem.WriteAllText(pathClients, Join(tempSortArray, vbNewLine), False)
        ReadCCSV()

    End Sub

    Function clearPCSV()
        'clears/deletes the WHOLE CSV of information
        Try
            My.Computer.FileSystem.WriteAllText(pathPlants, "Plant Name, Plant Quantity, Plant Type", False)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, vbCritical, "ERROR")
        End Try
        lbxPlantD.Items.Clear()
        lbxPlantD.Text = "There's nothing here yet! Add entries to the CSV to get started."
        Array.Clear(nameListP, 1, nameListP.Length - 1)
        Array.Clear(plantNumberP, 1, plantNumberP.Length - 1)
        Array.Clear(plantTypeP, 1, plantTypeP.Length - 1)
        ReadPCSV()
    End Function

    Function clearCCSV()
        'clears/deletes the WHOLE CSV of information
        Try
            My.Computer.FileSystem.WriteAllText(pathClients, "Client Name, Plant Name, Plant Type, Plant Quantity", False)
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, vbCritical, "ERROR")
        End Try
        lbxClientD.Items.Clear()
        lbxClientD.Text = "There's nothing here yet! Add entries to the CSV to get started."
        Array.Clear(clientName, 1, clientName.Length - 1)
        Array.Clear(plantNameC, 1, plantNameC.Length - 1)
        Array.Clear(plantTypeC, 1, plantTypeC.Length - 1)
        Array.Clear(plantNumberC, 1, plantNumberC.Length - 1)
        ReadCCSV()
    End Function

    Private Sub btnClearPData_Click(sender As Object, e As EventArgs) Handles btnClearPData.Click
        'connects the clear function to a button
        Dim sure As MsgBoxResult = MsgBox($"Are you sure you want to clear the CSV?{vbNewLine}This will permanently erase all data!", vbYesNo)
        If sure = MsgBoxResult.Yes Then
            clearPCSV()
            MsgBox("CSV data cleared")
        Else
            MsgBox("Oops - let's get you back to that normal screen")
        End If
    End Sub

    Private Sub btnClearCData_Click(sender As Object, e As EventArgs) Handles btnClearCData.Click
        'connects the clear function to the button
        Dim sure As MsgBoxResult = MsgBox($"Are you sure you want to clear the CSV?{vbNewLine}This will permanently erase all data!", vbYesNo)
        If sure = MsgBoxResult.Yes Then
            clearCCSV()
            MsgBox("CSV data cleared")
        Else
            MsgBox("Oops - let's get you back to that normal screen")
        End If
    End Sub
End Class