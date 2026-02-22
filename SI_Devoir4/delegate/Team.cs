using Observer;
using State;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Delegate;

public class Team 
{
    Doctor          doctor; //keep track of the doctor
    IDelegate       worker; //keep track of the leader
    List<IDelegate> team;   //the team

    public Team(Doctor doctor)
    {
        doctor.SetTeam(this);
        this.doctor = doctor;
        this.worker = doctor;
        this.team = new List<IDelegate>();
        this.team.Add(doctor);
    }
    
    public void AddMember(IDelegate member)
    {
        member.SetTeam(this);
        this.team.Add(member);
    }
    public IDelegate GetWorker()
    {
        return this.worker;
    }
    public List<IDelegate> GetTeamExceptWorker()
    {
        return this.team.Where(m => m.id != worker.id).ToList();
    }
    internal void Update()
    {
        // le docteur a toujours priorite sur 
        // le role leader
        if (this.doctor.state is NotTired)
        {
            this.worker = this.doctor;
        }
        // si leader n'a pas besoin de changer on ne change pas
        else if (this.worker.state is NotTired)
        {
            return;
        }
        else
        {
            // sinon le premier non fatiguer deviens leader
            this.worker = team.First(m => m.state is NotTired)
            //si personne est notTired le current worker rest current worker
            ?? this.worker;
        }
    }
}

