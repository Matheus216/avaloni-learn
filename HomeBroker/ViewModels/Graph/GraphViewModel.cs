using System;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.Painting;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using SkiaSharp;

namespace HomeBroker.ViewModels.Graph;

public partial class GraphViewModel : ObservableObject
{
    public ISeries[] Series { get; set; } = new[]
    {
        new CandlesticksSeries<FinancialPoint>
        {
            UpFill = new SolidColorPaint(SKColors.Blue),
            UpStroke = new SolidColorPaint(SKColors.CornflowerBlue) { StrokeThickness = 5 },
            DownFill = new SolidColorPaint(SKColors.Red),
            DownStroke = new SolidColorPaint(SKColors.Orange) { StrokeThickness = 5 },
            Values = new ObservableCollection<FinancialPoint>
            {
                //                             date,        high, open, close, low
                new FinancialPoint(new DateTime(2021, 1, 1), 523, 500, 450, 400),
                new FinancialPoint(new DateTime(2021, 1, 2), 500, 450, 425, 400),
                new FinancialPoint(new DateTime(2021, 1, 3), 490, 425, 400, 380),
                new FinancialPoint(new DateTime(2021, 1, 4), 420, 400, 420, 380),
                new FinancialPoint(new DateTime(2021, 1, 5), 520, 420, 490, 400),
                new FinancialPoint(new DateTime(2021, 1, 6), 580, 490, 560, 440),
                new FinancialPoint(new DateTime(2021, 1, 7), 570, 560, 350, 340),
                new FinancialPoint(new DateTime(2021, 1, 8), 380, 350, 380, 330),
                new FinancialPoint(new DateTime(2021, 1, 9), 440, 380, 420, 350),
                new FinancialPoint(new DateTime(2021, 1, 10), 490, 420, 460, 400),
                new FinancialPoint(new DateTime(2021, 1, 11), 520, 460, 510, 460),
                new FinancialPoint(new DateTime(2021, 1, 12), 580, 510, 560, 500),
                new FinancialPoint(new DateTime(2021, 1, 13), 600, 560, 540, 510),
                new FinancialPoint(new DateTime(2021, 1, 14), 580, 540, 520, 500),
                new FinancialPoint(new DateTime(2021, 1, 15), 580, 520, 560, 520),
                new FinancialPoint(new DateTime(2021, 1, 16), 590, 560, 580, 520),
                new FinancialPoint(new DateTime(2021, 1, 17), 650, 580, 630, 550),
                new FinancialPoint(new DateTime(2021, 1, 18), 680, 630, 650, 600),
                new FinancialPoint(new DateTime(2021, 1, 19), 670, 650, 600, 570),
                new FinancialPoint(new DateTime(2021, 1, 20), 640, 600, 610, 560),
                new FinancialPoint(new DateTime(2021, 1, 21), 630, 610, 630, 590),
            }
        }
    };

    public LabelVisual Title { get; set; } = new()
    {
        Text = "My first chart",
        TextSize = 24,
        Padding = new LiveChartsCore.Drawing.Padding(15),
        Paint = new SolidColorPaint(SKColors.DarkBlue)
    };
    
    public Axis[] XAxes { get; set; } = new[]
    {
        new Axis
        {
            LabelsRotation = 15,
            Labeler = value => new DateTime((long)value).ToString("yyyy MMM dd"),
            // set the unit width of the axis to "days"
            // since our X axis is of type date time and 
            // the interval between our points is in days
            UnitWidth = TimeSpan.FromDays(1).Ticks
        }
    };
}