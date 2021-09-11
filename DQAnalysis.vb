Sub DQAnalysis()
    Worksheets("DQ Analysis").Activate

        Range("A1").Value = "DAQO (Ticker: DQ)"

        'Create a header row
        Cells(3, 1).Value = "Year"
        Cells(3, 2).Value = "Total Daily Volume"
        Cells(3, 3).Value = "Return"
    Worksheets("2018").Activate
        
        'Set initial volume to zero
        totalVolume = 0

        Dim startingPrice As Double
        Dim endingPrice as Double
        
        'rowEnd code taken from https://stackoverflow.com/questions/18088729/row-count-where-data-exists
        rowCount = Cells(Rows.Count, "A").End(xlUp).Row
        
    'loop over all rows
    For i = 2 To rowCount
        'increase totalVolume if ticker is "DQ"
        If Cells(i, 1).Value = "DQ" Then
            totalVolume = totalVolume + Cells(i, 8).Value
        End If

        If Cells(i - 1, 1).Value <> "DQ" And Cells(i, 1).Value = "DQ" Then
            startingPrice = Cells(i,6).Value
        End If

        If Cells(i + 1, 1).Value <> "DQ" And Cells(i, 1).Value = "DQ" Then
            endingPrice = Cells(i,6).Value
        End If

    Next i

    Worksheets("DQ Analysis").Activate
        Cells(4, 1).Value = 2018
        Cells(4, 2).Value = totalVolume
        Cells(4, 3).Value = endingPrice / startingPrice - 1

End Sub