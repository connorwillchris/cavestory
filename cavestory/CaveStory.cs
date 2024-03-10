//using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace cavestory;

public class CaveStory : ModSystem {
    private ICoreServerAPI serverApi;
    //private ICoreClientAPI clientAPI;

    public override void Start(ICoreAPI api) {
        api.Logger.Notification("Hello world from cavestory");
    }

    public override void StartServerSide(ICoreServerAPI api) {
        serverApi = api;
    }
}
