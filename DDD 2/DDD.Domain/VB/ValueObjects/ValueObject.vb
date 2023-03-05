Namespace DDD.Domain.ValueObjects
    Public MustInherit Class ValueObject(Of T As ValueObject(Of T))
        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim vo = TryCast(obj, T)

            If vo Is Nothing Then
                Return False
            End If

            Return EqualsCore(vo)
        End Function

        Public Shared Operator =(ByVal vo1 As ValueObject(Of T), ByVal vo2 As ValueObject(Of T)) As Boolean
            Return Equals(vo1, vo2)
        End Operator

        Public Shared Operator <>(ByVal vo1 As ValueObject(Of T), ByVal vo2 As ValueObject(Of T)) As Boolean
            Return Not Equals(vo1, vo2)
        End Operator

        Protected MustOverride Function EqualsCore(ByVal other As T) As Boolean

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function
    End Class
End Namespace
