Public Class Client_Data
    'note that a lot of the functions here are simular to that in plantData

    Dim clientName(0) As String
    Dim plantType(0) As String
    Dim plantName(0) As String
    Dim currentEntry As String
    Dim plantNumber(0)
    Dim NumOfChange As Integer
    Dim path As String = "E:\Back-upSAT\SAT\SATPartB\ClientData.csv"

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
                lbxClientSearch.Items.Clear()

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
                            Case 4
                                If rowTicker = plantName.Length Then
                                    ReDim Preserve plantName(UBound(plantName) + 1)
                                    plantName(UBound(plantName)) = cell
                                Else
                                    plantNumber(rowTicker) = cell
                                End If
                                listBoxEntry += ", " & cell
                                lbxClientSearch.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                    rowTicker += 1
                End While
                If rowTicker = 0 Then
                    lblSearchClient.Text = "There are no current plant entries." & vbNewLine & "Add entries to the CSV to get started."
                Else
                    lblSearchClient.Text = "There are " & (rowTicker - 1) & " plants logged in this CSV."
                End If
            End Using
        Catch ex As Exception
            Dim errorMessage = MsgBox("An error occurred while reading the CSV: " & ex.Message & vbNewLine & "Please try again.", vbCritical)
        End Try
    End Function

    Private Sub btnBackC_Click(sender As Object, e As EventArgs) Handles btnBackC.Click

        Me.Hide()
        HomePage.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSearchClient.Text = "Loading File..."
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
                                ReDim Preserve clientName(UBound(clientName) + 1)
                                clientName(UBound(clientName)) = cell
                                listBoxEntry += cell
                            Case 2
                                ReDim Preserve plantName(UBound(plantName) + 1)
                                plantName(UBound(plantName)) = cell
                                listBoxEntry += ": " & cell
                            Case 3
                                ReDim Preserve plantType(UBound(plantType) + 1)
                                plantType(UBound(plantType)) = cell
                                listBoxEntry += ", " & cell
                            Case 4
                                ReDim Preserve plantNumber(UBound(plantNumber) + 1)
                                plantNumber(UBound(plantNumber)) = cell
                                listBoxEntry += ", " & cell
                                lbxClientSearch.Items.Add(listBoxEntry)
                                listBoxEntry = ""
                        End Select
                    Next
                    cellTicker = 0
                End If
                rowTicker += 1
            End While
        End Using
        lblSearchClient.Text = "CSV File Loaded Into Array"
    End Sub

    'writes to the CSV (function only)
    Function WriteToCSV(name, plantName, plantType, plantNumber)
        ReadCSV()
        currentEntry = vbNewLine & name & "," & plantName & "," & plantType & "," & plantNumber
        My.Computer.FileSystem.WriteAllText(path, currentEntry, True)
        ReadCSV()
    End Function

    'enter new data
    Private Sub btnCDatabase_Click(sender As Object, e As EventArgs) Handles btnCDatabase.Click

        Dim name As String = tbxClientName.Text
        'Check for Empty Field:
        If name = "" Then
            MsgBox(" Please enter a CLIENT NAME in the text box above", vbCritical)
        Else
            Try
                Dim plantName = InputBox(" Please enter the NAME of the plant that " + name + " has ordered ")
                If plantName = "" Then
                    MsgBox("Please enter a PLANT NAME into the text box", vbCritical)
                Else
                    Dim plantType = InputBox("Please enter the TYPE of plant that " + plantName + " is ")
                    If plantType = "" Then
                        MsgBox(" Please enter a PLANT TYPE in the text box", vbCritical)
                    Else
                        Dim plantNumber As String = InputBox("Please enter the QUANTITY of " + plantName + " ordered ")
                        If IsNumeric(plantNumber) And plantNumber >= 0 And plantNumber <= 100000 Then
                            WriteToCSV(name, plantName, plantType, plantNumber)
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox("An error has occured: " & ex.Message & vbNewLine & "Please try again")
            End Try
        End If

    End Sub

    'searches the function - same as for plant data
    Private Sub btnEnterSearch_Click(sender As Object, e As EventArgs) Handles btnEnterSearch.Click
        Dim nameToSearch = InputBox("Let's Find Your Entry." & vbNewLine & "Enter Client Name: ")
        Dim locator As Integer = 0
        Dim found As Boolean = False
        For Each client In clientName
            lblSearchClient.Text = "Searching..."
            locator += 1
            If client = nameToSearch Then
                lblSearchClient.Text = "Client: " & nameToSearch & " Found!"
                Dim location As Integer = locator - 1
                lblResults.Text = nameToSearch & "'s Orders are:" & vbNewLine & "Plant Type: " & plantType(location) & vbNewLine & "Plant Name: " & plantName(location) & vbNewLine & "Plant Quantity: " & plantNumber(location)
                found = True
                Exit For
            End If
        Next
        If found = False Then
            lblSearchClient.Text = "Client Not Found" & vbNewLine & "Please try again"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxClientName.Clear()
    End Sub
End Class