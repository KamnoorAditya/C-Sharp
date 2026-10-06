using System;
using System.Collections.Generic;

class Guest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<string> RoomHistory { get; set; }
    public string MembershipLevel { get; set; }
    public int StayDuration { get; set; }

    public Guest(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
        RoomHistory = new List<string>();
        MembershipLevel = null;
        StayDuration = 0;
    }

    public void AddStay(string details, int duration)
    {
        RoomHistory.Add(details);
        StayDuration += duration;
    }

    public string LastStay()
    {
        if (RoomHistory.Count == 0)
        {
            return null;
        }

        return RoomHistory[RoomHistory.Count - 1];
    }

    public void ViewHistory()
    {
        foreach (string stay in RoomHistory)
        {
            Console.WriteLine(stay);
        }
    }
}

class VIPGuest : Guest
{
    public VIPGuest(int id, string name, string email)
        : base(id, name, email)
    {
    }

    public void SetMembershipLevel(string level)
    {
        MembershipLevel = level;
    }

    public string ComplimentaryUpgrade()
    {
        if (StayDuration >= 5)
        {
            return "Suite";
        }

        return "Deluxe";
    }

    public void LateCheckout(int hours)
    {
        if (hours <= 4)
        {
            Console.WriteLine("Late checkout approved");
        }
        else
        {
            Console.WriteLine("Late checkout denied");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Guest guest = new Guest(1, "Aditya", "aditya@gmail.com");

        guest.AddStay("Room 101 - 2 nights", 2);
        guest.AddStay("Room 205 - 3 nights", 3);

        Console.WriteLine("Guest ID: " + guest.Id);
        Console.WriteLine("Guest Name: " + guest.Name);
        Console.WriteLine("Guest Email: " + guest.Email);
        Console.WriteLine("Total Stay Duration: " + guest.StayDuration);
        Console.WriteLine("Last Stay: " + guest.LastStay());

        Console.WriteLine("Stay History:");
        guest.ViewHistory();

        Console.WriteLine();

        VIPGuest vip = new VIPGuest(2, "Rahul", "rahul@gmail.com");

        vip.SetMembershipLevel("Gold");

        vip.AddStay("Deluxe Room - 2 nights", 2);
        vip.AddStay("Deluxe Room - 3 nights", 3);

        Console.WriteLine("VIP Guest ID: " + vip.Id);
        Console.WriteLine("VIP Guest Name: " + vip.Name);
        Console.WriteLine("VIP Membership: " + vip.MembershipLevel);
        Console.WriteLine("VIP Total Stay Duration: " + vip.StayDuration);
        Console.WriteLine("Last VIP Stay: " + vip.LastStay());
        Console.WriteLine("Complimentary Upgrade: " + vip.ComplimentaryUpgrade());

        vip.LateCheckout(4);

        Console.WriteLine("VIP Stay History:");
        vip.ViewHistory();
    }
}
