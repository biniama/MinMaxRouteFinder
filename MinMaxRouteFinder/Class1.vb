'Imports System.IO

'Public Class frmRouteFinder

'    Dim fileName As String = "C:\Routes2.txt"

'    'Declare a StreamReader object and read from the file
'    Private myStreamReader As StreamReader

'    'Declare an object to store the whole content of the file and 
'    'Save the whole content of the file in the variable called "content"
'    Private item As Object

'    'Declare a string variable to store the content that is read from the file
'    Private content As String = String.Empty

'    Public Structure strOurNodes

'        Dim node As String
'        Dim successors As List(Of String)
'        Dim minmaxLevel As String
'        Dim distance As Integer

'    End Structure

'    Public objOurNodes As New List(Of strOurNodes)

'    Public ourNode As strOurNodes

'    Public ourDictionary As New Dictionary(Of String, String)

'    Public Sub ourDictionaryInitializer()

'        For Each n In objOurNodes

'            If n.successors.Count = 0 Then
'                ourDictionary.Add(n.node, n.distance)
'            End If

'        Next

'        'With ourDictionary

'        '    .Add("Bulgaria", 7)
'        '    .Add("Sarbet", 8)
'        '    .Add("Stadium", 9)
'        '    .Add("Cherkos", 7)
'        '    .Add("Dembel", 13)
'        '    .Add("Kera2", 9)
'        '    .Add("ShewaDabo", 14)
'        '    .Add("Mekanisa", 15)

'        'End With

'    End Sub

'    Dim childValue As New Dictionary(Of String, Integer)

'    Public Function MinMax(ByVal newNode As String, ByVal depth As Integer) As Integer

'        Dim minimumValue As Integer
'        Dim maximumValue As Integer
'        Dim depthValue As Integer = 0

'        Dim maxDepth As Integer = 3

'        'childValue = New Dictionary(Of String, Integer)

'        For Each n In objOurNodes

'            If n.node.Equals(newNode) Then

'                ' Checks if the node is the root node or depth 
'                If depth = maxDepth Then

'                    depthValue = ourDictionary.Item(n.node)
'                    childValue.Add(newNode, depthValue)
'                    Return depthValue

'                ElseIf n.minmaxLevel.Equals("min") Then

'                    minimumValue = 1000000000

'                    For Each child In n.successors

'                        minimumValue = Math.Min(minimumValue, MinMax(child, depth + 1))

'                        If childValue.ContainsKey(child) = False Then
'                            childValue.Add(child, minimumValue)
'                        End If

'                    Next

'                    Return minimumValue

'                ElseIf n.minmaxLevel.Equals("max") Then

'                    maximumValue = -1000000000

'                    For Each child In n.successors

'                        maximumValue = Math.Max(maximumValue, MinMax(child, depth + 1))

'                        If childValue.ContainsKey(child) = False Then
'                            childValue.Add(child, maximumValue)
'                        End If

'                    Next

'                    Return maximumValue

'                End If

'            End If

'        Next

'    End Function

'    Dim optimalPath As New List(Of String)

'    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

'        If IsNothing(fileName) Or fileName.Equals(String.Empty) = True Then
'            MessageBox.Show("Please select the location of the file.", "Route Finding Using Min-Max Algorithm", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        ElseIf fileName.Equals(String.Empty) = False Then
'            content = ReadFromFile(fileName)
'            If content.Equals("No") Then
'                MessageBox.Show("Sorry! The file you selected is not found or cannot be read.", "Route Finding Using Min-Max Algorithm", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End If

'            ourTokenizer(content)

'            Dim strDestination As String
'            strDestination = txtDestinationPlace.Text

'            Dim ourList As New List(Of String)

'            ' Initialize the dictionary
'            If IsNothing(ourDictionary) Or ourDictionary.Count = 0 Then
'                ourDictionaryInitializer()
'            End If

'            childValue.Clear()

'            Dim finalValue As Integer = 0
'            finalValue = MinMax(strDestination, 0)

'            MessageBox.Show("The optimal kilometer is: " & finalValue)

'            For Each x In childValue

'                If x.Value = finalValue Then

'                    ourList.Add(x.Key)

'                End If

'            Next

'            Dim toBePrinted As String = String.Empty

'            For Each o In ourList

'                toBePrinted &= o & " --> "

'            Next

'            MessageBox.Show("The optimal path is : " & toBePrinted & strDestination)

'        End If

'    End Sub

'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'        '   Call ourInitializer()
'        '  Call ourDictionaryInitializer()

'        txtDestinationPlace.Text = String.Empty
'        txtDestinationPlace.Focus()




'        '  Dim finalPlace As String

'        ' finalPlace = ourDictionary(finalValue)
'        'ourDictionary.
'        ' optimalPath.Add(finalPlace)

'        'For Each place In objOurNodes

'        '    For Each s In place.successors
'        '        If s.Equals(optimalPath.Last) Then

'        '            optimalPath.Add(place.node)
'        '            Exit For
'        '        End If

'        '    Next

'        'Next

'        ''   optimalPath.Add()

'        'For Each x In optimalPath
'        '    MessageBox.Show(x)
'        'Next


'    End Sub

'    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

'        OpenFileDialog1.FileName = "C:\Routes2.txt"

'        'Show the open dialog and if the user clicks the open button load the file
'        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
'            Try
'                'Save the file name in the variable called "filename1"
'                fileName = OpenFileDialog1.FileName
'                txtFileSelected.Text = fileName

'            Catch ex As Exception               'FileNotFoundException
'                'If there is any exception related to opening file, display an exception (error) message to the user
'                MessageBox.Show("The file you selected is not found.", "Route Finding Using Min-Max Algorithm", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If


'    End Sub

'    Public Function ReadFromFile(ByVal filename As String) As String

'        If IO.File.Exists(filename) Then
'            myStreamReader = IO.File.OpenText(filename)

'            content = String.Empty

'            item = myStreamReader.ReadToEnd

'            content = content & item.ToString.Trim

'            'When finished reading from the file, close the StreamReader
'            myStreamReader.Close()

'            Return content

'        Else
'            Return "No"
'        End If

'    End Function

'    Private Sub ourTokenizer(ByVal content As String)

'        Dim separators As Char()
'        separators = {"{", "_", "}", "~", ",", "."}

'        Dim mylist As New List(Of String)

'        mylist = content.Split(separators).ToList()

'        Dim successorsLocal As New List(Of String)

'        For e As Integer = 0 To mylist.Count - 1 Step 1

'            successorsLocal.Clear()

'            If mylist(e).Trim.Equals(String.Empty) = False Then

'                ourNode.node = mylist(e).Trim

'                If mylist(e + 1).Trim.Equals("*") Then
'                    ourNode.node = mylist(e).Trim

'                    '  ourNode.successors.Add(mylist(e + 2))
'                    e += 1
'                    While IsNumeric(mylist(e + 1)) = False
'                        e += 1
'                        successorsLocal.Add(mylist(e))

'                    End While

'                    e += 1
'                    If IsNumeric(mylist(e)) Then
'                        If mylist(e) = 1 Then
'                            ourNode.minmaxLevel = "max"
'                        ElseIf mylist(e) = 0 Then
'                            ourNode.minmaxLevel = "min"
'                        Else
'                            ourNode.distance = mylist(e)
'                        End If
'                    End If

'                End If

'                ourNode.successors = Nothing

'                'If IsNothing(ourNode.successors) = False Then
'                '    ourNode.successors.RemoveRange(0, ourNode.successors.Count)
'                'End If
'                ' For Each s In successorsLocal
'                ourNode.successors = New List(Of String)(successorsLocal)
'                'Next
'                objOurNodes.Add(ourNode)

'            End If

'        Next

'    End Sub

'    Public Sub ourInitializer()
'        ourNode.successors = New List(Of String)

'        ourNode.node = "Saris"
'        ourNode.successors.Add("Gotera")
'        ourNode.successors.Add("BihereTsige")
'        ourNode.successors.Add("Abo")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Gotera"
'        ourNode.successors.Add("Kera")
'        ourNode.successors.Add("Lancha")
'        ourNode.successors.Add("WolloSefer")
'        ourNode.minmaxLevel = "min"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Kera"
'        ourNode.successors.Add("Bulgaria")
'        ourNode.successors.Add("Sarbet")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Lancha"
'        ourNode.successors.Add("Stadium")
'        ourNode.successors.Add("Cherkos")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "WolloSefer"
'        ourNode.successors.Add("Dembel")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Bulgaria"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Sarbet"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Stadium"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Cherkos"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Dembel"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "BihereTsige"
'        ourNode.successors.Add("MebratHail")
'        ourNode.minmaxLevel = "min"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "MebratHail"
'        ourNode.successors.Add("Kera2")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Kera2"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Abo"
'        ourNode.successors.Add("Bole")
'        ourNode.successors.Add("KalityMaseltegna")
'        ourNode.minmaxLevel = "min"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Bole"
'        ourNode.successors.Add("ShewaDabo")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "KalityMaseltegna"
'        ourNode.successors.Add("Mekanisa")
'        ourNode.minmaxLevel = "max"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "ShewaDabo"
'        objOurNodes.Add(ourNode)

'        ResetNodes()

'        ourNode.node = "Mekanisa"
'        objOurNodes.Add(ourNode)

'    End Sub

'    Public Sub ResetNodes()

'        ourNode.node = Nothing
'        ourNode.successors = New List(Of String)

'    End Sub

'    Public Function goalTestFunction() As Integer

'        'If 

'    End Function

'End Class
