'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ProductMm
    Public Property ProductId As Integer
    Public Property Description As String
    Public Property BaseConcurrency As String

    Public Property Dimensions As DimensionsMm = New DimensionsMm
    Public Property ComplexConcurrency As ConcurrencyInfoMm = New ConcurrencyInfoMm
    Public Property NestedComplexConcurrency As Another.Place.AuditInfoMm = New Another.Place.AuditInfoMm

    Public Overridable Property Suppliers As ICollection(Of SupplierMm) = New HashSet(Of SupplierMm)
    Public Overridable Property Replaces As ICollection(Of DiscontinuedProductMm) = New HashSet(Of DiscontinuedProductMm)
    Public Overridable Property Detail As ProductDetailMm
    Public Overridable Property Reviews As ICollection(Of ProductReviewMm) = New HashSet(Of ProductReviewMm)
    Public Overridable Property Photos As ICollection(Of ProductPhotoMm) = New HashSet(Of ProductPhotoMm)
    Public Overridable Property Barcodes As ICollection(Of BarcodeMm) = New HashSet(Of BarcodeMm)

End Class
