using MySql.Data.MySqlClient;
using ServiceStack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace member_space
{
    internal class EventMethods : DatabaseConnection
    {
        public List<EventData> GetEvents() 
            //Get all events and their details
        {
            List<EventData> events = new List<EventData>();
            using (var connection = get_Connection()) 
            {
                connection.Open();

                string query = "SELECT EventActivityID, AdminID, Address, " +
                        "Postcode, BuildingName,Type,Description" +
                        ",EventDate,Duration,MaxCapacity,EventName FROM eventactivity";
                using (var command = new MySqlCommand(query, connection)) 
                {
                    using (var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            var eventInstance = new EventData
                            {
                                EventID = reader.GetInt32("EventActivityID"),
                                AdminID = reader.GetInt32("AdminID"),
                                Address = reader.GetString("Address"),
                                Postcode = reader.GetString("PostCode"),
                                BuildingName = reader.GetString("BuildingName"),
                                Type = reader.GetString("Type"),
                                Description = reader.GetString("Description"),
                                Date = reader.GetDateTime("EventDate"),
                                Duration = reader.GetInt32("Duration"),
                                MaxCapacity = reader.GetInt32("MaxCapacity"),
                                EventName = reader.GetString("EventName"),
                            };
                            events.Add(eventInstance);
            
                        }
                    }
                }
            }
            return events;
        }
        public bool UpdateEvent(EventData updatedEvent) 
        {//This will changed event details 
            using (var connection = get_Connection()) 
            {
                connection.Open();
                string query = @"
                UPDATE eventactivity
                SET 
                    AdminID = @AdminID,
                    Address = @Address,
                    Postcode = @Postcode,
                    BuildingName = @BuildingName,
                    Type = @Type,
                    Description = @Description,
                    EventDate = @Date,
                    Duration = @Duration,
                    MaxCapacity = @MaxCapacity,
                    EventName = @EventName
                    WHERE EventActivityID = @EventID";
                using (var command = new MySqlCommand(query, connection)) 
                {
                    command.Parameters.AddWithValue("@EventID", updatedEvent.EventID);
                    command.Parameters.AddWithValue("@AdminID", updatedEvent.AdminID);
                    command.Parameters.AddWithValue("@Address", updatedEvent.Address);
                    command.Parameters.AddWithValue("@Postcode", updatedEvent.Postcode);
                    command.Parameters.AddWithValue("@BuildingName", updatedEvent.BuildingName);
                    command.Parameters.AddWithValue("@Type", updatedEvent.Type);
                    command.Parameters.AddWithValue("@Description", updatedEvent.Description);
                    command.Parameters.AddWithValue("@Date", updatedEvent.Date);
                    command.Parameters.AddWithValue("@Duration", updatedEvent.Duration);
                    command.Parameters.AddWithValue("@MaxCapacity", updatedEvent.MaxCapacity);
                    command.Parameters.AddWithValue("@EventName", updatedEvent.EventName);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
               
            }
            
        }
        public bool saveEvent(string eventId, string adminId, string address, string postcode,
    string buildingName, string eventType, string description, DateTime date,
    string duration, string maxCapacity, string eventName)
        
        {
            if (string.IsNullOrEmpty(eventId))
                return false;
            var updatedEvent = new EventData
            {
                EventID = int.Parse(eventId),
                AdminID = int.Parse(adminId),
                Address = address,
                Postcode = postcode,
                BuildingName = buildingName,
                Type = eventType,
                Description = description,
                Date = date,
                Duration = int.Parse(duration),
                MaxCapacity = int.Parse(maxCapacity),
                EventName = eventName
            };
            var eventMethods = new EventMethods();
            return eventMethods.UpdateEvent(updatedEvent);
        }
        public bool createEvent(EventData newEvent)
        {
            using (var connection = get_Connection())
            {
                connection.Open();
                string query = "INSERT INTO eventactivity " +
                       "(AdminID, Address, Postcode, BuildingName, Type, Description, " +
                       "EventDate, Duration, MaxCapacity, EventName) " +
                       "VALUES (@AdminID, @Address, @Postcode, @BuildingName, @Type, @Description, " +
                       "@EventDate, @Duration, @MaxCapacity, @EventName)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminID", newEvent.AdminID);
                    command.Parameters.AddWithValue("@Address", newEvent.Address);
                    command.Parameters.AddWithValue("@Postcode", newEvent.Postcode);
                    command.Parameters.AddWithValue("@BuildingName", newEvent.BuildingName);
                    command.Parameters.AddWithValue("@Type", newEvent.Type);
                    command.Parameters.AddWithValue("@Description", newEvent.Description);
                    command.Parameters.AddWithValue("@EventDate", newEvent.Date);
                    command.Parameters.AddWithValue("@Duration", newEvent.Duration);
                    command.Parameters.AddWithValue("@MaxCapacity", newEvent.MaxCapacity);
                    command.Parameters.AddWithValue("@EventName", newEvent.EventName);

                    int rowsAffected = command.ExecuteNonQuery();
                    return (rowsAffected > 0);
                }
            }
            
        }
        
        public string suffixHelp(int day)
            //This function will help return the proper suffix for the dates in the calendar
        {
            if (day % 100 >= 11 && day % 100 <= 13) 
                return "th";
            switch (day % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            };
        }
        public List<EventData> getEventsByMonth(DateTime start_Date,DateTime end_Date)
            //
        { 
            List<EventData> events = new List<EventData>();
            using (var connection = get_Connection())
            {
                connection.Open();
                string query = "Select EventName,EventDate FROM eventactivity WHERE EventDate BETWEEN @startDate AND @endDate";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", start_Date.Date);
                    command.Parameters.AddWithValue("@endDate", end_Date.Date);
                    using (var reader = command.ExecuteReader()) 
                    {
                        
                        while (reader.Read()) 
                        {
                            events.Add(new EventData
                            {
                                EventName = reader.GetString("EventName"),
                                Date = reader.GetDateTime("EventDate")
                            });
                        }
                    }

                }
            }
            return events;
        }
    }
   
}
