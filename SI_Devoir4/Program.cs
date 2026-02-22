using Delegate;


Doctor doctor = new Doctor(10, "Dara");
Team team = new Team(doctor);


team.AddMember(new Nurse(7, "Mia"));
team.AddMember(new Paramedic(10, "Michael"));

while (true)
{
    team.GetWorker().Work();
    team.GetTeamExceptWorker().ForEach(m => m.Rest());

    Console.WriteLine("\n ---- next tick ----");
    Thread.Sleep(1000);
}
