﻿' <Chapter 3.1>

    Namespace DI

    Public Class CGreat
 
        Private ReadOnly _greet As IGreet

        Public Sub New(greet As IGreet)
            _greet = greet
        End Sub

        Public Sub SayHello()
            _greet.Greet
        End Sub

    End Class

    End Namespace