﻿Imports System.Data

Public Class Items
    Inherits DataTable

    Public Sub New()
        Me.Columns.Add("Label")
        Me.Columns.Add("Accion")
        Me.Columns.Add("Case")

        Dim newRow As DataRow

        newRow = Me.NewRow()
        newRow.Item("Label") = 100015
        'accion
        newRow.Item("Accion") = 100015
        'case del aspx
        newRow.Item("Case") = 100015
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100016
        'accion
        newRow.Item("Accion") = 100016
        'case del aspx
        newRow.Item("Case") = 100016
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100020
        'accion
        newRow.Item("Accion") = 100020
        'case del aspx
        newRow.Item("Case") = 100020
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100021
        'accion
        newRow.Item("Accion") = 100021
        'case del aspx
        newRow.Item("Case") = 100021
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100022
        'accion
        newRow.Item("Accion") = 100022
        'case del aspx
        newRow.Item("Case") = 100022
        Me.Rows.Add(newRow)

    End Sub
End Class