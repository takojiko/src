Imports System

Namespace DDD.Domain.ValueObjects
    Public NotInheritable Class AreaId
        Inherits ValueObject(Of AreaId)

        Public Sub New(ByVal value As Integer)
            Value = value
        End Sub

        Public ReadOnly Property Value As Integer

        Protected Overrides Function EqualsCore(ByVal other As AreaId) As Boolean
            Return Value = other.Value
        End Function

        Public ReadOnly Property DisplayValue As String
            Get
                Return Value.ToString().PadLeft(4, "0"c)
            End Get
        End Property
    End Class
End Namespace