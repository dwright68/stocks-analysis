Sub AllStocksAnalysis()
' 1. Format the output sheet on the "All Stocks Analysis" worksheet.
    Worksheets("All Stocks Analysis").Activate
        Range("A1").Value = "All Stocks (2018)"
        'Create a header row
        Cells(3, 1).Value = "Ticker"
        Cells(3, 2).Value = "Total Daily Volume"
        Cells(3, 3).Value = "Return"
' 2. Initialize an array of all tickers.
    dim tickers(11) As String
        tickers(0) = "AY"
        tickers(1) = "CSIQ"
        tickers(2) = "DQ"
        tickers(3) = "ENPH"
        tickers(4) = "FSLR"
        tickers(5) = "HASI"
        tickers(6) = "JKS"
        tickers(7) = "RUN"
        tickers(8) = "SEDG"
        tickers(9) = "SPWR"
        tickers(10) = "TERP"
        tickers(11) = "VSLR"
' 3. Prepare for the analysis of tickers.
       'Initialize variables for the starting price and ending price.
    Dim startingPrice As Single
    Dim endingPrice as Single
       'Activate the data worksheet.
    Worksheets("2018").Activate
       'Find the number of rows to loop over.
        rowCount = Cells(Rows.Count, "A").End(xlUp).Row
' 4. Loop through the tickers.
        For i = 0 to 11
            ticker = tickers(i)
            TotalVolume = 0
' 5. Loop through rows in the data.
            Worksheets("2018").Activate
            For j = 2 To rowCount
        'Find the total volume for the current ticker.
                If Cells(j, 1).Value = ticker Then
                    totalVolume = totalVolume + Cells(j, 8).Value
                End If
        'Find the starting price for the current ticker.
                If Cells(j - 1, 1).Value <> ticker And Cells(j, 1).Value = ticker Then
                    startingPrice = Cells(j, 6).Value
                End If
        'Find the ending price for the current ticker.
                If Cells(j + 1, 1).Value <> ticker And Cells(j, 1).Value = ticker Then
                    endingPrice = Cells(j, 6).Value
                End If
            Next j
' 6. Output the data for the current ticker.
            Worksheets("All Stocks Analysis").Activate
                Cells(4 + i, 1).Value = 2018
                Cells(4 + i, 2).Value = totalVolume
                Cells(4 + i, 3).Value = endingPrice / startingPrice - 1
        next i
End Sub