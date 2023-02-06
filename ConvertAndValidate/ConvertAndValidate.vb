'Joshua Makuch
'RCET 0265
'Fall 2023
'Convert And Validate
'https://github.com/JoshuaMakuch/ConvertAndValidate.git

Option Strict On
Option Explicit On

Imports System

Module ConvertAndValidate
    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
        Dim usernResponse As String

        Do

            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()

            'If the number converts successfully in the function it will return a true and convert it here
            If ConversionValid(usernResponse, aValidNumber) = True Then

                aValidNumber = CInt(usernResponse)
                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber} !")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be an integer.")

            End If

        Loop

        'make this work
    End Sub

    Function ConversionValid(convertThisString As String, toThisInteger As Integer) As Boolean

        'the toThisInteger is needed here to input the conversion of convertThisString otherwise it gives an error
        'but it basically checks if the user input can convert to an integer and returns the status of that conversion
        Try
            toThisInteger = CInt(convertThisString)
            Return True
        Catch ex As Exception
            Return False
        End Try

        Return False

    End Function

End Module
