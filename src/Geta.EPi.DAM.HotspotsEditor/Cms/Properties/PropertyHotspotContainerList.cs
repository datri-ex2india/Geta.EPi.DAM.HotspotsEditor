using System.Collections.Generic;
using EPiServer.PlugIn;
using Geta.EPi.DAM.HotspotsEditor.Cms.Models;

namespace Geta.EPi.DAM.HotspotsEditor.Cms.Properties
{
    [PropertyDefinitionTypePlugIn(Description = "A property for picking hotspots.", DisplayName = "Hotspot list")]
    public class PropertyHotspotContainerList : PropertyJsonSerializedObject<List<HotSpotContainer>>
    {
        
    }
}