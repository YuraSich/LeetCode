public class UndergroundSystem {
    
    public void CheckIn(int id, string stationName, int t) {
        currentTrips[id] = (stationName, t);
    }
    
    public void CheckOut(int id, string endStation, int endTime) {
        var (startStation, startTime) = currentTrips[id];
        var time = endTime - startTime;
        var key = (startStation, endStation);
        if (averageTimes.ContainsKey(key)) {
            var (average, trips) = averageTimes[key];
            averageTimes[key] = ((average*trips+time)/(trips+1),trips+1);
        } else {
            averageTimes[key] = (time, 1);
        }
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        return averageTimes[(startStation,endStation)].Average;
    }
    
    private Dictionary<int, (string Station, int Time)> currentTrips = new Dictionary<int, (string, int)>();
    private Dictionary<(string, string), (double Average, int)> averageTimes = new Dictionary<(string, string),(double,int)>();
}