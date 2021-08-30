using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion.Network.Interface.BinDumps
{
    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("AO-Resources", Namespace = "", IsNullable = false)]
    public partial class AOResources
    {

        private AOResourcesResource[] resourcesField;

        private AOResourcesHarvestable[] harvestablesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Resource", IsNullable = false)]
        public AOResourcesResource[] Resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Harvestable", IsNullable = false)]
        public AOResourcesHarvestable[] Harvestables
        {
            get
            {
                return this.harvestablesField;
            }
            set
            {
                this.harvestablesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesResource
    {

        private AOResourcesResourceResourceTier[] resourceTierField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceTier")]
        public AOResourcesResourceResourceTier[] ResourceTier
        {
            get
            {
                return this.resourceTierField;
            }
            set
            {
                this.resourceTierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesResourceResourceTier
    {

        private byte valueField;

        private decimal resourcevalueField;

        private decimal famevalueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal resourcevalue
        {
            get
            {
                return this.resourcevalueField;
            }
            set
            {
                this.resourcevalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal famevalue
        {
            get
            {
                return this.famevalueField;
            }
            set
            {
                this.famevalueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesHarvestable
    {

        private AOResourcesHarvestableModifier[] toolModifierField;

        private AOResourcesHarvestableTier[] tierField;

        private string nameField;

        private string resourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modifier", IsNullable = false)]
        public AOResourcesHarvestableModifier[] ToolModifier
        {
            get
            {
                return this.toolModifierField;
            }
            set
            {
                this.toolModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tier")]
        public AOResourcesHarvestableTier[] Tier
        {
            get
            {
                return this.tierField;
            }
            set
            {
                this.tierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesHarvestableModifier
    {

        private sbyte tierdifferenceField;

        private decimal timefactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte tierdifference
        {
            get
            {
                return this.tierdifferenceField;
            }
            set
            {
                this.tierdifferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal timefactor
        {
            get
            {
                return this.timefactorField;
            }
            set
            {
                this.timefactorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesHarvestableTier
    {

        private AOResourcesHarvestableTierCharge[] chargeField;

        private AOResourcesHarvestableTierRareState[] rareStateField;

        private byte tierField;

        private string itemField;

        private byte maxchargesperharvestField;

        private decimal respawntimesecondsField;

        private bool respawntimesecondsFieldSpecified;

        private decimal harvesttimesecondsField;

        private bool requirestoolField;

        private byte notooltimefactorField;

        private bool notooltimefactorFieldSpecified;

        private byte startchargesField;

        private bool startchargesFieldSpecified;

        private string tileField;

        private uint decaytimesecondsField;

        private bool decaytimesecondsFieldSpecified;

        private uint decaytimewhenexhaustedsecondsField;

        private bool decaytimewhenexhaustedsecondsFieldSpecified;

        private string tilepremiumField;

        private bool isscaledField;

        private bool isscaledFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Charge")]
        public AOResourcesHarvestableTierCharge[] Charge
        {
            get
            {
                return this.chargeField;
            }
            set
            {
                this.chargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RareState")]
        public AOResourcesHarvestableTierRareState[] RareState
        {
            get
            {
                return this.rareStateField;
            }
            set
            {
                this.rareStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte tier
        {
            get
            {
                return this.tierField;
            }
            set
            {
                this.tierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte maxchargesperharvest
        {
            get
            {
                return this.maxchargesperharvestField;
            }
            set
            {
                this.maxchargesperharvestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal respawntimeseconds
        {
            get
            {
                return this.respawntimesecondsField;
            }
            set
            {
                this.respawntimesecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool respawntimesecondsSpecified
        {
            get
            {
                return this.respawntimesecondsFieldSpecified;
            }
            set
            {
                this.respawntimesecondsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal harvesttimeseconds
        {
            get
            {
                return this.harvesttimesecondsField;
            }
            set
            {
                this.harvesttimesecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool requirestool
        {
            get
            {
                return this.requirestoolField;
            }
            set
            {
                this.requirestoolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte notooltimefactor
        {
            get
            {
                return this.notooltimefactorField;
            }
            set
            {
                this.notooltimefactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool notooltimefactorSpecified
        {
            get
            {
                return this.notooltimefactorFieldSpecified;
            }
            set
            {
                this.notooltimefactorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte startcharges
        {
            get
            {
                return this.startchargesField;
            }
            set
            {
                this.startchargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startchargesSpecified
        {
            get
            {
                return this.startchargesFieldSpecified;
            }
            set
            {
                this.startchargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tile
        {
            get
            {
                return this.tileField;
            }
            set
            {
                this.tileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint decaytimeseconds
        {
            get
            {
                return this.decaytimesecondsField;
            }
            set
            {
                this.decaytimesecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool decaytimesecondsSpecified
        {
            get
            {
                return this.decaytimesecondsFieldSpecified;
            }
            set
            {
                this.decaytimesecondsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint decaytimewhenexhaustedseconds
        {
            get
            {
                return this.decaytimewhenexhaustedsecondsField;
            }
            set
            {
                this.decaytimewhenexhaustedsecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool decaytimewhenexhaustedsecondsSpecified
        {
            get
            {
                return this.decaytimewhenexhaustedsecondsFieldSpecified;
            }
            set
            {
                this.decaytimewhenexhaustedsecondsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tilepremium
        {
            get
            {
                return this.tilepremiumField;
            }
            set
            {
                this.tilepremiumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isscaled
        {
            get
            {
                return this.isscaledField;
            }
            set
            {
                this.isscaledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isscaledSpecified
        {
            get
            {
                return this.isscaledFieldSpecified;
            }
            set
            {
                this.isscaledFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesHarvestableTierCharge
    {

        private string levelField;

        private byte gfxstateField;

        private decimal respawnfactorminField;

        private bool respawnfactorminFieldSpecified;

        private decimal respawnfactormaxField;

        private bool respawnfactormaxFieldSpecified;

        private ushort respawnchargesField;

        private bool respawnchargesFieldSpecified;

        private decimal yieldField;

        private bool yieldFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte gfxstate
        {
            get
            {
                return this.gfxstateField;
            }
            set
            {
                this.gfxstateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal respawnfactormin
        {
            get
            {
                return this.respawnfactorminField;
            }
            set
            {
                this.respawnfactorminField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool respawnfactorminSpecified
        {
            get
            {
                return this.respawnfactorminFieldSpecified;
            }
            set
            {
                this.respawnfactorminFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal respawnfactormax
        {
            get
            {
                return this.respawnfactormaxField;
            }
            set
            {
                this.respawnfactormaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool respawnfactormaxSpecified
        {
            get
            {
                return this.respawnfactormaxFieldSpecified;
            }
            set
            {
                this.respawnfactormaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort respawncharges
        {
            get
            {
                return this.respawnchargesField;
            }
            set
            {
                this.respawnchargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool respawnchargesSpecified
        {
            get
            {
                return this.respawnchargesFieldSpecified;
            }
            set
            {
                this.respawnchargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal yield
        {
            get
            {
                return this.yieldField;
            }
            set
            {
                this.yieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool yieldSpecified
        {
            get
            {
                return this.yieldFieldSpecified;
            }
            set
            {
                this.yieldFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AOResourcesHarvestableTierRareState
    {

        private byte stateField;

        private string itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }


}
