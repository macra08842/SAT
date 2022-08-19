Public Class PlantData

    'Define any variables that will be used
    Dim nameList(0) As String
    Dim plantType(0) As String
    Dim currentEntry As String
    Dim plantNumber(0)
    Dim NumOfChange As Integer
    Dim path As String = "E:\Back-upSAT\SAT\SATPartB\PlantData.csv"

    'Read the CSV function cell by cell and line by line
    Function ReadCSV()
        Try
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)

                'Define the Necessary Variables:
                Dim cellTicker As Integer = 0
                Dim rowTicker As Integer = 0
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim row As String()
                Dim listBoxEntry As String
                lbxDataBase.Items.Clear()

                'Loop Through Each Row:
                While Not MyReader.EndOfData
                    row = MyReader.ReadFields()
                    'Loop Through Each Cell:
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 1
                                If rowTicker = nameList.Length Then
                                    ReDim Preserve nameList(UBound(nameList) + 1)
                                End If
                                nameList(rowTicker) = cell
                                listBoxEntry += cell
                            Case 2
                                If rowTicker = plantType.Length Then
                                    ReDim Preserve plantType(UBound(plantType) + 1)
                                    plantType(UBound(plantType)) = cell
                                Else
                                    plantType(rowTicker) = cell
                                End If
                                listBoxEntry += ": " & cell
                            Case 3
                                If rowTicker = plantNumber.Length Then
                                    ReDim Preserve plantNumber(UBound(plantNumber) + 1)
                                    plantNumber(UBound(plantNumber)) = cell
                                Else
                                    plantNumber(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                                lbxDataBase.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    lblResults.Text = "There are no current plant entries." & vbNewLine & "Add entries to the CSV to get started."
                Else
                    lblResults.Text = "There are " & (rowTicker - 1) & " plants logged in this CSV."
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    Function WriteToCSV(name, type, number)
        ReadCSV()
        'Add mark details to file
        currentEntry = vbNewLine & name & "," & type & "," & number
        My.Computer.FileSystem.WriteAllText(path, currentEntry, True)
        ReadCSV()
    End Function

    Private Sub btnBackP_Click(sender As Object, e As EventArgs) Handles btnBackP.Click
        'When clicked, this button sends the user back to the home page
        Me.Hide()
        HomePage.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSearchPlant.Text = "Loading File..."
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
            'DEFINE THE NECESSARY VARIABLES:
            Dim cellTicker As Integer = 0
            Dim rowTicker As Integer = 0
            Dim listBoxEntry As String
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim row As String()

            'LOOP THROUGH EACH ROW
            While Not MyReader.EndOfData
                row = MyReader.ReadFields()
                'LOOP THROUGH EACH CELL
                If rowTicker > 0 Then
                    For Each cell In row
                        cellTicker += 1
                        Select Case cellTicker
                            Case 1
                                ReDim Preserve nameList(UBound(nameList) + 1)
                                nameList(UBound(nameList)) = cell
                                listBoxEntry += cell
                            Case 2
                                ReDim Preserve plantNumber(UBound(plantNumber) + 1)
                                plantNumber(UBound(plantNumber)) = cell
                                listBoxEntry += ": " & cell
                            Case 3
                                ReDim Preserve plantType(UBound(plantType) + 1)
                                plantType(UBound(plantType)) = cell
                                listBoxEntry += ", " & cell

                        End Select
                    Next
                    cellTicker = 0
                End If
                rowTicker += 1
            End While
        End Using
        lblSearchPlant.Text = "CSV File Loaded Into Array"
    End Sub

    'when the software loads, read the CSV

    Private Sub PlantData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadCSV()
    End Sub

    Private Sub btnSearchPlants_Click(sender As Object, e As EventArgs) Handles btnSearchPlants.Click
        Dim nameToSearch = InputBox("Let's Find Your Entry." & vbNewLine & "Enter Plant Name: ")
        Dim locator As Integer = 0
        Dim found As Boolean = False
        'goes through each line of the code until a match is found
        For Each plant In nameList
            lblSearchPlant.Text = "Searching..."
            locator += 1
            If plant = nameToSearch Then
                lblSearchPlant.Text = "Plant " & nameToSearch & " Found!"
                Dim location As Integer = locator - 1
                lblResults.Text = nameToSearch & "  Results:" & vbNewLine & "Number Avaliable: " & plantType(location) & vbNewLine & "Type of plant: " & plantNumber(location)
                found = True
                Exit For
            End If
        Next
        If found = False Then
            lblSearchPlant.Text = "Plant not found" & vbNewLine & "Please try again"
        End If
    End Sub
    'writes to the bottom of the CSV in an empty field
    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        Dim name As String = tbxNewPlant.Text
        'Check for Empty Field:
        If name = "" Then
            MsgBox(" Please enter a PLANT NAME in the text box above", vbCritical)
        Else
            Try
                Dim plantType = InputBox("Please enter the TYPE of plant that " + name + " is: ")
                If plantType = "" Then
                    MsgBox("Please enter a PLANT TYPE in the text box ", vbCritical)
                Else
                    Dim plantNumber As String = InputBox("Please enter the QUANTITY of " + name + " currently in stock ")
                    If IsNumeric(plantNumber) And plantNumber >= 0 And plantNumber <= 100000 Then
                        WriteToCSV(name, plantNumber, plantType)
                    Else
                        MsgBox(" Please enter the PLANT QUANTITY as a positive number 100000 or less ", vbCritical)
                    End If
                End If
            Catch ex As Exception
                MsgBox("An error has occurred: " & ex.Message & vbNewLine & "Please try again")
            End Try
        End If

    End Sub


    'Clears the text box
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResults.Text = "Results"
    End Sub

    Private Sub btnCleartbx_Click(sender As Object, e As EventArgs) Handles btnCleartbx.Click
        tbxNewPlant.Clear()
    End Sub

    Private Sub btnClearModify_Click(sender As Object, e As EventArgs) Handles btnClearModify.Click
        tbxNameChange.Clear()
    End Sub

    'Delete Record within CSV
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        Dim nameToModify As String = tbxNameChange.Text
        Dim locator As Integer = 0
        Dim found As Boolean = False
        Dim tempDFile As String = "tempD.csv"
        Dim deleteRecord As Boolean = False
        Dim delimiter As String = ","
        ' Dim newRecord As String = nameList + delimiter + plantType + delimiter + plantNumber

        For Each plant In nameList
            locator += 1
            If plant = nameToModify Then
                'Dim location As Integer = locator - 1
                found = True
                Exit For
            End If
        Next
        Dim dYes As MsgBoxResult = MsgBox(nameToModify & " found! Would you like to delete this entry?", vbYesNo)
        If found = False Then
            MsgBox("Searched Item: " & nameToModify & " was not found. Please Try again")
        End If

        If dYes = MsgBoxResult.Yes And found = True Then
            Try
                Dim fileReader As New System.IO.StreamReader(path)
                Dim fileWriter As New System.IO.StreamWriter(tempDFile, True)

                Do While fileReader.Peek() <> -1
                    currentEntry = fileReader.ReadLine()
                    Dim currentRecord() As String = Split(currentEntry, ",")
                    'compare the read position with the name to modify, and if it equals tue, write it to the temp file
                    If (Not String.Compare(currentRecord(locator), nameToModify) = 0) Then
                        fileWriter.WriteLine(currentEntry)

                    Else
                        deleteRecord = True

                    End If
                Loop

                fileWriter.Close()
                fileReader.Close()
                ' delete original file, and replace the temp file details to path's
                My.Computer.FileSystem.DeleteFile(path)
                My.Computer.FileSystem.RenameFile(tempDFile, path)


            Catch ex As Exception
                MsgBox("An error has occured: " & ex.Message & vbNewLine & "Please Try again")
            End Try
        End If

        ' Return deleteRecord

    End Sub
    'Modify Record
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim nameToModify As String = tbxNameChange.Text
        Dim locator As Integer = 0
        Dim found As Boolean = False
        Dim tempMFile As String = "tempM.csv"

        Dim editedRecord As Boolean = False
        Dim deleteRecord As Boolean = False
        Dim delimiter As String = ","
        ' Dim newRecord As String = nameList + delimiter + plantType + delimiter + plantNumber

        For Each plant In nameList
            locator += 1
            If plant = nameToModify Then
                Dim location As Integer = locator - 1
                found = True
                Exit For
            End If
        Next
        Dim dYes As MsgBoxResult = MsgBox(nameToModify & " found! Would you like to modify this entry?", vbYesNo)
        If found = False Then
            MsgBox("Searched Item: " & nameToModify & " was not found. Please Try again")
        End If
        If dYes = MsgBoxResult.Yes And found = True Then
            Try
                'deletes the selected record
                Dim fileReader As New System.IO.StreamReader(path)
                Dim fileWriter As New System.IO.StreamWriter(tempMFile, True)

                Do While fileReader.Peek() <> -1
                    currentEntry = fileReader.ReadLine()
                    Dim currentRecord() As String = Split(currentEntry, ",")
                    If (Not String.Compare(currentRecord(locator), nameToModify) = 0) Then
                        fileWriter.WriteLine(currentEntry)

                    Else
                        deleteRecord = True

                    End If
                Loop

                fileWriter.Close()
                fileReader.Close()

                My.Computer.FileSystem.DeleteFile(path)
                My.Computer.FileSystem.RenameFile(tempMFile, path)

            Catch ex As Exception
                MsgBox("An error has occured: " & ex.Message & vbNewLine & "Please Try again")
            End Try
            'writes new record to replace the old one
            Dim name = InputBox("Please enter the PLANT NAME that you want to edit")
            If name = "" Then
                MsgBox(" Please enter a PLANT NAME in the text box above", vbCritical)
            Else
                Try
                    Dim plantType = InputBox("Please enter the TYPE of plant that " + name + " is: ")
                    If plantType = "" Then
                        MsgBox("Please enter a PLANT TYPE in the text box ", vbCritical)
                    Else
                        Dim plantNumber As String = InputBox("Please enter the QUANTITY of " + name + " currently in stock ")
                        If IsNumeric(plantNumber) And plantNumber >= 0 And plantNumber <= 100000 Then
                            WriteToCSV(name, plantNumber, plantType)
                        Else
                            MsgBox(" Please enter the PLANT QUANTITY as a positive number 100000 or less ", vbCritical)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("An error has occurred: " & ex.Message & vbNewLine & "Please try again")
                End Try
            End If
        End If
    End Sub
End Class