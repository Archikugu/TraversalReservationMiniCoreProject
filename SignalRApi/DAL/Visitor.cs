using System;

namespace SignalRApi.DAL
{
    public enum ECity
    {
        Berlin=1,
        İstanbul=2,
        Ankara=3,
        London=4,
        Eskisehir=5
    }
    public class Visitor
    {
        public int VisitorId { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
