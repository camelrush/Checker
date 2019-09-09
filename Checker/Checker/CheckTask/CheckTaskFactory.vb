Public Class CheckTaskFactory

    Public Enum crPattern
        patternX
        patternY
        patternZ
    End Enum

    Public Shared Function Create(ByVal pattern As crPattern, ByVal checkParam As String) As CheckTaskBase

        Dim checkTask As CheckTaskBase

        Select Case pattern
            Case crPattern.patternX : checkTask = New CheckTaskX()
            Case crPattern.patternY : checkTask = New CheckTaskY()
            Case crPattern.patternZ : checkTask = New CheckTaskZ()
        End Select

        checkTask.CheckParameter = checkParam

        Return checkTask

    End Function

End Class
