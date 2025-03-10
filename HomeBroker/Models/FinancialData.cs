using System;

namespace HomeBroker.Models;

public class FinancialData
{
    public DateTime Date { get; set; }
    public double High { get; set; }
    public double Open { get; set; }
    public double Close { get; set; }
    public double Low { get; set; }   
}