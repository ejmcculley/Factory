using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Details { get; set; }
    public int MachineId { get; set; }
    public virtual Machine Machine { get; set; }
    public virtual ICollection<CategoryEngineer> JoinEntities { get; }
  }
}