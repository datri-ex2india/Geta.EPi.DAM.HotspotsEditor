using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using Geta.EPi.DAM.HotspotsEditor.Cms.Models;

namespace Geta.EPi.DAM.HotspotsEditor.Cms.EditorDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(IEnumerable<HotSpotContainer>), UIHint = UIHint.HotspotsEditor)]
    public class HotspotsEditorDescriptor : EditorDescriptor
    {
        public HotspotsEditorDescriptor()
        {
            ClientEditingClass = "hotspots/editors/HotspotsEditor";
            
        }
    }
}