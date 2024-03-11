using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;

namespace cavestory;

public class Cavestory : ModSystem {

    public override void Start(ICoreAPI api) {
        // register the entities
        api.Logger.Notification("Cavestory: Registering Entities in CAVESTORY...");
        api.RegisterEntity("cavestory.EntityDinosaur", typeof(Cavestory.EntityDinosaur));

        api.Logger.Notification("Cavestory: Registering done!");
    }

    public abstract class EntityDinosaur : Entity {
        
    }
}
