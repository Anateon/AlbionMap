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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Mobs
    {

        private MobsMob[] mobField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mob")]
        public MobsMob[] Mob
        {
            get
            {
                return this.mobField;
            }
            set
            {
                this.mobField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMob
    {

        private object[] itemsField;

        private string uniquenameField;

        private byte tierField;

        private string npchostilityField;

        private decimal abilitypowerField;

        private uint fameField;

        private string avatarField;

        private string prefabField;

        private decimal prefabscaleField;

        private bool prefabscaleFieldSpecified;

        private byte roamingradiusField;

        private decimal roamingidletimeminField;

        private decimal roamingidletimemaxField;

        private decimal aggroradiusField;

        private decimal pursuitradiusField;

        private byte damageaggrofactorField;

        private byte healingaggrofactorField;

        private decimal shieldaggrofactorField;

        private decimal alertradiusField;

        private string factionField;

        private string alertsfactionsField;

        private decimal collisionradiusField;

        private decimal attackcollisionradiusField;

        private string attacktypeField;

        private decimal attackrangeField;

        private ushort attackdamageField;

        private decimal hitpointsmaxField;

        private decimal hitpointsregenerationField;

        private decimal energymaxField;

        private decimal energyregenerationField;

        private decimal movespeedField;

        private decimal attackmovespeedField;

        private decimal meleeattackdamagetimeField;

        private decimal attackspeedField;

        private ushort physicalarmorField;

        private ushort magicresistanceField;

        private uint crowdcontrolresistanceField;

        private decimal respawntimesecondsminField;

        private decimal respawntimesecondsmaxField;

        private string avatarringField;

        private ushort maxchargesField;

        private decimal timeperchargesecondsField;

        private string dangerstateField;

        private decimal aggrodelayafterspawnField;

        private bool isbossField;

        private bool isbossFieldSpecified;

        private string lootprefabField;

        private string energyrewardspellField;

        private ushort energyrewardField;

        private bool energyrewardFieldSpecified;

        private string namelocatagField;

        private bool immunetoforcedmovementField;

        private bool immunetoforcedmovementFieldSpecified;

        private bool isabletoexecuteField;

        private bool isabletoexecuteFieldSpecified;

        private bool fixedrotationField;

        private bool fixedrotationFieldSpecified;

        private byte startchargesField;

        private bool startchargesFieldSpecified;

        private bool onlysimpleroamingField;

        private bool onlysimpleroamingFieldSpecified;

        private string categoryField;

        private ushort chargesperchargeupField;

        private bool chargesperchargeupFieldSpecified;

        private decimal postDeathLifetimeField;

        private bool postDeathLifetimeFieldSpecified;

        private bool hidehealthbarField;

        private bool hidehealthbarFieldSpecified;

        private string dangericonspriteField;

        private bool dontresetafterpursuitField;

        private bool dontresetafterpursuitFieldSpecified;

        private byte gvgseasonpointsField;

        private bool gvgseasonpointsFieldSpecified;

        private decimal magicasttimereductionField;

        private bool magicasttimereductionFieldSpecified;

        private decimal magiccooldownreductionField;

        private bool magiccooldownreductionFieldSpecified;

        private bool chestwatchField;

        private bool chestwatchFieldSpecified;

        private decimal magicattackdamagetimeField;

        private bool magicattackdamagetimeFieldSpecified;

        private decimal rangedattackdamagetimeField;

        private bool rangedattackdamagetimeFieldSpecified;

        private byte focusfireattackersthresholdField;

        private bool focusfireattackersthresholdFieldSpecified;

        private bool factionwarfarekoField;

        private bool factionwarfarekoFieldSpecified;

        private bool protectedlootField;

        private bool protectedlootFieldSpecified;

        private byte hellinfamyField;

        private bool hellinfamyFieldSpecified;

        private bool usecombatgroupField;

        private bool usecombatgroupFieldSpecified;

        private bool seeinvisibilityField;

        private bool seeinvisibilityFieldSpecified;

        private byte minthreatfactorforchangetotargetinattackrangeField;

        private bool minthreatfactorforchangetotargetinattackrangeFieldSpecified;

        private byte minthreatfactorforchangetotargetoutsideattackrangeField;

        private bool minthreatfactorforchangetotargetoutsideattackrangeFieldSpecified;

        private byte aggrofrontalconelengthField;

        private bool aggrofrontalconelengthFieldSpecified;

        private byte aggrofrontalconeangleField;

        private bool aggrofrontalconeangleFieldSpecified;

        private bool mobtakeskillcreditField;

        private bool mobtakeskillcreditFieldSpecified;

        private ushort infamyField;

        private bool infamyFieldSpecified;

        private string executionspellField;

        private bool cankeepplayerincombatField;

        private bool cankeepplayerincombatFieldSpecified;

        private decimal physicalspelldamagebonusField;

        private bool physicalspelldamagebonusFieldSpecified;

        private byte silvermodifierField;

        private bool silvermodifierFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AI", typeof(MobsMobAI))]
        [System.Xml.Serialization.XmlElementAttribute("AssetVfxPreset", typeof(MobsMobAssetVfxPreset))]
        [System.Xml.Serialization.XmlElementAttribute("AudioInfo", typeof(MobsMobAudioInfo))]
        [System.Xml.Serialization.XmlElementAttribute("DeathSpells", typeof(MobsMobDeathSpells))]
        [System.Xml.Serialization.XmlElementAttribute("FootStepVfxPreset", typeof(MobsMobFootStepVfxPreset))]
        [System.Xml.Serialization.XmlElementAttribute("Loot", typeof(MobsMobLoot))]
        [System.Xml.Serialization.XmlElementAttribute("MinimapDisplay", typeof(MobsMobMinimapDisplay))]
        [System.Xml.Serialization.XmlElementAttribute("SocketPreset", typeof(MobsMobSocketPreset))]
        [System.Xml.Serialization.XmlElementAttribute("SpawnSpells", typeof(MobsMobSpawnSpells))]
        [System.Xml.Serialization.XmlElementAttribute("Spells", typeof(MobsMobSpells))]
        [System.Xml.Serialization.XmlElementAttribute("projectile", typeof(MobsMobProjectile))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uniquename
        {
            get
            {
                return this.uniquenameField;
            }
            set
            {
                this.uniquenameField = value;
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
        public string npchostility
        {
            get
            {
                return this.npchostilityField;
            }
            set
            {
                this.npchostilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal abilitypower
        {
            get
            {
                return this.abilitypowerField;
            }
            set
            {
                this.abilitypowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint fame
        {
            get
            {
                return this.fameField;
            }
            set
            {
                this.fameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string avatar
        {
            get
            {
                return this.avatarField;
            }
            set
            {
                this.avatarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefab
        {
            get
            {
                return this.prefabField;
            }
            set
            {
                this.prefabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal prefabscale
        {
            get
            {
                return this.prefabscaleField;
            }
            set
            {
                this.prefabscaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prefabscaleSpecified
        {
            get
            {
                return this.prefabscaleFieldSpecified;
            }
            set
            {
                this.prefabscaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte roamingradius
        {
            get
            {
                return this.roamingradiusField;
            }
            set
            {
                this.roamingradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal roamingidletimemin
        {
            get
            {
                return this.roamingidletimeminField;
            }
            set
            {
                this.roamingidletimeminField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal roamingidletimemax
        {
            get
            {
                return this.roamingidletimemaxField;
            }
            set
            {
                this.roamingidletimemaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal aggroradius
        {
            get
            {
                return this.aggroradiusField;
            }
            set
            {
                this.aggroradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal pursuitradius
        {
            get
            {
                return this.pursuitradiusField;
            }
            set
            {
                this.pursuitradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte damageaggrofactor
        {
            get
            {
                return this.damageaggrofactorField;
            }
            set
            {
                this.damageaggrofactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte healingaggrofactor
        {
            get
            {
                return this.healingaggrofactorField;
            }
            set
            {
                this.healingaggrofactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal shieldaggrofactor
        {
            get
            {
                return this.shieldaggrofactorField;
            }
            set
            {
                this.shieldaggrofactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal alertradius
        {
            get
            {
                return this.alertradiusField;
            }
            set
            {
                this.alertradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string faction
        {
            get
            {
                return this.factionField;
            }
            set
            {
                this.factionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alertsfactions
        {
            get
            {
                return this.alertsfactionsField;
            }
            set
            {
                this.alertsfactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal collisionradius
        {
            get
            {
                return this.collisionradiusField;
            }
            set
            {
                this.collisionradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attackcollisionradius
        {
            get
            {
                return this.attackcollisionradiusField;
            }
            set
            {
                this.attackcollisionradiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string attacktype
        {
            get
            {
                return this.attacktypeField;
            }
            set
            {
                this.attacktypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attackrange
        {
            get
            {
                return this.attackrangeField;
            }
            set
            {
                this.attackrangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort attackdamage
        {
            get
            {
                return this.attackdamageField;
            }
            set
            {
                this.attackdamageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal hitpointsmax
        {
            get
            {
                return this.hitpointsmaxField;
            }
            set
            {
                this.hitpointsmaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal hitpointsregeneration
        {
            get
            {
                return this.hitpointsregenerationField;
            }
            set
            {
                this.hitpointsregenerationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal energymax
        {
            get
            {
                return this.energymaxField;
            }
            set
            {
                this.energymaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal energyregeneration
        {
            get
            {
                return this.energyregenerationField;
            }
            set
            {
                this.energyregenerationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal movespeed
        {
            get
            {
                return this.movespeedField;
            }
            set
            {
                this.movespeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attackmovespeed
        {
            get
            {
                return this.attackmovespeedField;
            }
            set
            {
                this.attackmovespeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal meleeattackdamagetime
        {
            get
            {
                return this.meleeattackdamagetimeField;
            }
            set
            {
                this.meleeattackdamagetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal attackspeed
        {
            get
            {
                return this.attackspeedField;
            }
            set
            {
                this.attackspeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort physicalarmor
        {
            get
            {
                return this.physicalarmorField;
            }
            set
            {
                this.physicalarmorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort magicresistance
        {
            get
            {
                return this.magicresistanceField;
            }
            set
            {
                this.magicresistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint crowdcontrolresistance
        {
            get
            {
                return this.crowdcontrolresistanceField;
            }
            set
            {
                this.crowdcontrolresistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal respawntimesecondsmin
        {
            get
            {
                return this.respawntimesecondsminField;
            }
            set
            {
                this.respawntimesecondsminField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal respawntimesecondsmax
        {
            get
            {
                return this.respawntimesecondsmaxField;
            }
            set
            {
                this.respawntimesecondsmaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string avatarring
        {
            get
            {
                return this.avatarringField;
            }
            set
            {
                this.avatarringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort maxcharges
        {
            get
            {
                return this.maxchargesField;
            }
            set
            {
                this.maxchargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal timeperchargeseconds
        {
            get
            {
                return this.timeperchargesecondsField;
            }
            set
            {
                this.timeperchargesecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dangerstate
        {
            get
            {
                return this.dangerstateField;
            }
            set
            {
                this.dangerstateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal aggrodelayafterspawn
        {
            get
            {
                return this.aggrodelayafterspawnField;
            }
            set
            {
                this.aggrodelayafterspawnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isboss
        {
            get
            {
                return this.isbossField;
            }
            set
            {
                this.isbossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isbossSpecified
        {
            get
            {
                return this.isbossFieldSpecified;
            }
            set
            {
                this.isbossFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lootprefab
        {
            get
            {
                return this.lootprefabField;
            }
            set
            {
                this.lootprefabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string energyrewardspell
        {
            get
            {
                return this.energyrewardspellField;
            }
            set
            {
                this.energyrewardspellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort energyreward
        {
            get
            {
                return this.energyrewardField;
            }
            set
            {
                this.energyrewardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool energyrewardSpecified
        {
            get
            {
                return this.energyrewardFieldSpecified;
            }
            set
            {
                this.energyrewardFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string namelocatag
        {
            get
            {
                return this.namelocatagField;
            }
            set
            {
                this.namelocatagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool immunetoforcedmovement
        {
            get
            {
                return this.immunetoforcedmovementField;
            }
            set
            {
                this.immunetoforcedmovementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool immunetoforcedmovementSpecified
        {
            get
            {
                return this.immunetoforcedmovementFieldSpecified;
            }
            set
            {
                this.immunetoforcedmovementFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isabletoexecute
        {
            get
            {
                return this.isabletoexecuteField;
            }
            set
            {
                this.isabletoexecuteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isabletoexecuteSpecified
        {
            get
            {
                return this.isabletoexecuteFieldSpecified;
            }
            set
            {
                this.isabletoexecuteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool fixedrotation
        {
            get
            {
                return this.fixedrotationField;
            }
            set
            {
                this.fixedrotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fixedrotationSpecified
        {
            get
            {
                return this.fixedrotationFieldSpecified;
            }
            set
            {
                this.fixedrotationFieldSpecified = value;
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
        public bool onlysimpleroaming
        {
            get
            {
                return this.onlysimpleroamingField;
            }
            set
            {
                this.onlysimpleroamingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onlysimpleroamingSpecified
        {
            get
            {
                return this.onlysimpleroamingFieldSpecified;
            }
            set
            {
                this.onlysimpleroamingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort chargesperchargeup
        {
            get
            {
                return this.chargesperchargeupField;
            }
            set
            {
                this.chargesperchargeupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chargesperchargeupSpecified
        {
            get
            {
                return this.chargesperchargeupFieldSpecified;
            }
            set
            {
                this.chargesperchargeupFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal postDeathLifetime
        {
            get
            {
                return this.postDeathLifetimeField;
            }
            set
            {
                this.postDeathLifetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postDeathLifetimeSpecified
        {
            get
            {
                return this.postDeathLifetimeFieldSpecified;
            }
            set
            {
                this.postDeathLifetimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hidehealthbar
        {
            get
            {
                return this.hidehealthbarField;
            }
            set
            {
                this.hidehealthbarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hidehealthbarSpecified
        {
            get
            {
                return this.hidehealthbarFieldSpecified;
            }
            set
            {
                this.hidehealthbarFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dangericonsprite
        {
            get
            {
                return this.dangericonspriteField;
            }
            set
            {
                this.dangericonspriteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool dontresetafterpursuit
        {
            get
            {
                return this.dontresetafterpursuitField;
            }
            set
            {
                this.dontresetafterpursuitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dontresetafterpursuitSpecified
        {
            get
            {
                return this.dontresetafterpursuitFieldSpecified;
            }
            set
            {
                this.dontresetafterpursuitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte gvgseasonpoints
        {
            get
            {
                return this.gvgseasonpointsField;
            }
            set
            {
                this.gvgseasonpointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gvgseasonpointsSpecified
        {
            get
            {
                return this.gvgseasonpointsFieldSpecified;
            }
            set
            {
                this.gvgseasonpointsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal magicasttimereduction
        {
            get
            {
                return this.magicasttimereductionField;
            }
            set
            {
                this.magicasttimereductionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool magicasttimereductionSpecified
        {
            get
            {
                return this.magicasttimereductionFieldSpecified;
            }
            set
            {
                this.magicasttimereductionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal magiccooldownreduction
        {
            get
            {
                return this.magiccooldownreductionField;
            }
            set
            {
                this.magiccooldownreductionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool magiccooldownreductionSpecified
        {
            get
            {
                return this.magiccooldownreductionFieldSpecified;
            }
            set
            {
                this.magiccooldownreductionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool chestwatch
        {
            get
            {
                return this.chestwatchField;
            }
            set
            {
                this.chestwatchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chestwatchSpecified
        {
            get
            {
                return this.chestwatchFieldSpecified;
            }
            set
            {
                this.chestwatchFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal magicattackdamagetime
        {
            get
            {
                return this.magicattackdamagetimeField;
            }
            set
            {
                this.magicattackdamagetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool magicattackdamagetimeSpecified
        {
            get
            {
                return this.magicattackdamagetimeFieldSpecified;
            }
            set
            {
                this.magicattackdamagetimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal rangedattackdamagetime
        {
            get
            {
                return this.rangedattackdamagetimeField;
            }
            set
            {
                this.rangedattackdamagetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rangedattackdamagetimeSpecified
        {
            get
            {
                return this.rangedattackdamagetimeFieldSpecified;
            }
            set
            {
                this.rangedattackdamagetimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte focusfireattackersthreshold
        {
            get
            {
                return this.focusfireattackersthresholdField;
            }
            set
            {
                this.focusfireattackersthresholdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool focusfireattackersthresholdSpecified
        {
            get
            {
                return this.focusfireattackersthresholdFieldSpecified;
            }
            set
            {
                this.focusfireattackersthresholdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool factionwarfareko
        {
            get
            {
                return this.factionwarfarekoField;
            }
            set
            {
                this.factionwarfarekoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool factionwarfarekoSpecified
        {
            get
            {
                return this.factionwarfarekoFieldSpecified;
            }
            set
            {
                this.factionwarfarekoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool protectedloot
        {
            get
            {
                return this.protectedlootField;
            }
            set
            {
                this.protectedlootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool protectedlootSpecified
        {
            get
            {
                return this.protectedlootFieldSpecified;
            }
            set
            {
                this.protectedlootFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hellinfamy
        {
            get
            {
                return this.hellinfamyField;
            }
            set
            {
                this.hellinfamyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hellinfamySpecified
        {
            get
            {
                return this.hellinfamyFieldSpecified;
            }
            set
            {
                this.hellinfamyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool usecombatgroup
        {
            get
            {
                return this.usecombatgroupField;
            }
            set
            {
                this.usecombatgroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool usecombatgroupSpecified
        {
            get
            {
                return this.usecombatgroupFieldSpecified;
            }
            set
            {
                this.usecombatgroupFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool seeinvisibility
        {
            get
            {
                return this.seeinvisibilityField;
            }
            set
            {
                this.seeinvisibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seeinvisibilitySpecified
        {
            get
            {
                return this.seeinvisibilityFieldSpecified;
            }
            set
            {
                this.seeinvisibilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte minthreatfactorforchangetotargetinattackrange
        {
            get
            {
                return this.minthreatfactorforchangetotargetinattackrangeField;
            }
            set
            {
                this.minthreatfactorforchangetotargetinattackrangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minthreatfactorforchangetotargetinattackrangeSpecified
        {
            get
            {
                return this.minthreatfactorforchangetotargetinattackrangeFieldSpecified;
            }
            set
            {
                this.minthreatfactorforchangetotargetinattackrangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte minthreatfactorforchangetotargetoutsideattackrange
        {
            get
            {
                return this.minthreatfactorforchangetotargetoutsideattackrangeField;
            }
            set
            {
                this.minthreatfactorforchangetotargetoutsideattackrangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minthreatfactorforchangetotargetoutsideattackrangeSpecified
        {
            get
            {
                return this.minthreatfactorforchangetotargetoutsideattackrangeFieldSpecified;
            }
            set
            {
                this.minthreatfactorforchangetotargetoutsideattackrangeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte aggrofrontalconelength
        {
            get
            {
                return this.aggrofrontalconelengthField;
            }
            set
            {
                this.aggrofrontalconelengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggrofrontalconelengthSpecified
        {
            get
            {
                return this.aggrofrontalconelengthFieldSpecified;
            }
            set
            {
                this.aggrofrontalconelengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte aggrofrontalconeangle
        {
            get
            {
                return this.aggrofrontalconeangleField;
            }
            set
            {
                this.aggrofrontalconeangleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggrofrontalconeangleSpecified
        {
            get
            {
                return this.aggrofrontalconeangleFieldSpecified;
            }
            set
            {
                this.aggrofrontalconeangleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool mobtakeskillcredit
        {
            get
            {
                return this.mobtakeskillcreditField;
            }
            set
            {
                this.mobtakeskillcreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mobtakeskillcreditSpecified
        {
            get
            {
                return this.mobtakeskillcreditFieldSpecified;
            }
            set
            {
                this.mobtakeskillcreditFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort infamy
        {
            get
            {
                return this.infamyField;
            }
            set
            {
                this.infamyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool infamySpecified
        {
            get
            {
                return this.infamyFieldSpecified;
            }
            set
            {
                this.infamyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string executionspell
        {
            get
            {
                return this.executionspellField;
            }
            set
            {
                this.executionspellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool cankeepplayerincombat
        {
            get
            {
                return this.cankeepplayerincombatField;
            }
            set
            {
                this.cankeepplayerincombatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cankeepplayerincombatSpecified
        {
            get
            {
                return this.cankeepplayerincombatFieldSpecified;
            }
            set
            {
                this.cankeepplayerincombatFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal physicalspelldamagebonus
        {
            get
            {
                return this.physicalspelldamagebonusField;
            }
            set
            {
                this.physicalspelldamagebonusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool physicalspelldamagebonusSpecified
        {
            get
            {
                return this.physicalspelldamagebonusFieldSpecified;
            }
            set
            {
                this.physicalspelldamagebonusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte silvermodifier
        {
            get
            {
                return this.silvermodifierField;
            }
            set
            {
                this.silvermodifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool silvermodifierSpecified
        {
            get
            {
                return this.silvermodifierFieldSpecified;
            }
            set
            {
                this.silvermodifierFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAI
    {

        private object[] itemsField;

        private string referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Behaviour", typeof(MobsMobAIBehaviour))]
        [System.Xml.Serialization.XmlElementAttribute("Events", typeof(MobsMobAIEvents))]
        [System.Xml.Serialization.XmlElementAttribute("Variables", typeof(MobsMobAIVariables))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviour
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("If", typeof(MobsMobAIBehaviourIF))]
        [System.Xml.Serialization.XmlElementAttribute("SelectRandom", typeof(MobsMobAIBehaviourSelectRandom))]
        [System.Xml.Serialization.XmlElementAttribute("Spell", typeof(MobsMobAIBehaviourSpell))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIF
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompoundAction", typeof(MobsMobAIBehaviourIFCompoundAction))]
        [System.Xml.Serialization.XmlElementAttribute("IfChance", typeof(MobsMobAIBehaviourIFIfChance))]
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobAIBehaviourIFIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsAnyEnemyInRange", typeof(MobsMobAIBehaviourIFIfIsAnyEnemyInRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobAIBehaviourIFIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive", typeof(MobsMobAIBehaviourIFIfSpellActive))]
        [System.Xml.Serialization.XmlElementAttribute("IfVariable", typeof(MobsMobAIBehaviourIFIfVariable))]
        [System.Xml.Serialization.XmlElementAttribute("SelectFirst", typeof(MobsMobAIBehaviourIFSelectFirst))]
        [System.Xml.Serialization.XmlElementAttribute("SelectRandom", typeof(MobsMobAIBehaviourIFSelectRandom))]
        [System.Xml.Serialization.XmlElementAttribute("Spell", typeof(MobsMobAIBehaviourIFSpell))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobAIBehaviourIFNot))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFCompoundAction
    {

        private MobsMobAIBehaviourIFCompoundActionSpell spellField;

        private MobsMobAIBehaviourIFCompoundActionBroadcastVariable broadcastVariableField;

        private MobsMobAIBehaviourIFCompoundActionVariable variableField;

        /// <remarks/>
        public MobsMobAIBehaviourIFCompoundActionSpell Spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourIFCompoundActionBroadcastVariable BroadcastVariable
        {
            get
            {
                return this.broadcastVariableField;
            }
            set
            {
                this.broadcastVariableField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourIFCompoundActionVariable Variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFCompoundActionSpell
    {

        private string targetField;

        private string nameField;

        private byte cooldowntillnextcastField;

        private bool cooldowntillnextcastFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
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
        public byte cooldowntillnextcast
        {
            get
            {
                return this.cooldowntillnextcastField;
            }
            set
            {
                this.cooldowntillnextcastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cooldowntillnextcastSpecified
        {
            get
            {
                return this.cooldowntillnextcastFieldSpecified;
            }
            set
            {
                this.cooldowntillnextcastFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFCompoundActionBroadcastVariable
    {

        private bool includeSelfField;

        private string nameField;

        private byte radiusField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool includeSelf
        {
            get
            {
                return this.includeSelfField;
            }
            set
            {
                this.includeSelfField = value;
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
        public byte radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFCompoundActionVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfChance
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfIsAnyEnemyInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFIfVariable
    {

        private string nameField;

        private string opField;

        private string valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirst
    {

        private MobsMobAIBehaviourIFSelectFirstSpell[] spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spell")]
        public MobsMobAIBehaviourIFSelectFirstSpell[] Spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpell
    {

        private object[] itemsField;

        private string nameField;

        private string targetField;

        private decimal cooldowntillnextcastField;

        private bool cooldowntillnextcastFieldSpecified;

        private string cooldowngroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Event", typeof(MobsMobAIBehaviourIFSelectFirstSpellEvent))]
        [System.Xml.Serialization.XmlElementAttribute("IfChance", typeof(MobsMobAIBehaviourIFSelectFirstSpellIfChance))]
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobAIBehaviourIFSelectFirstSpellIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobAIBehaviourIFSelectFirstSpellIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetRange", typeof(MobsMobAIBehaviourIFSelectFirstSpellIfTargetRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfVariable", typeof(MobsMobAIBehaviourIFSelectFirstSpellIfVariable))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobAIBehaviourIFSelectFirstSpellNot))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cooldowntillnextcast
        {
            get
            {
                return this.cooldowntillnextcastField;
            }
            set
            {
                this.cooldowntillnextcastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cooldowntillnextcastSpecified
        {
            get
            {
                return this.cooldowntillnextcastFieldSpecified;
            }
            set
            {
                this.cooldowntillnextcastFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cooldowngroup
        {
            get
            {
                return this.cooldowngroupField;
            }
            set
            {
                this.cooldowngroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellEvent
    {

        private MobsMobAIBehaviourIFSelectFirstSpellEventVariable variableField;

        private MobsMobAIBehaviourIFSelectFirstSpellEventBroadcastVariable broadcastVariableField;

        private string typeField;

        /// <remarks/>
        public MobsMobAIBehaviourIFSelectFirstSpellEventVariable Variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourIFSelectFirstSpellEventBroadcastVariable BroadcastVariable
        {
            get
            {
                return this.broadcastVariableField;
            }
            set
            {
                this.broadcastVariableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellEventVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellEventBroadcastVariable
    {

        private bool includeSelfField;

        private string nameField;

        private bool valueField;

        private byte radiusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool includeSelf
        {
            get
            {
                return this.includeSelfField;
            }
            set
            {
                this.includeSelfField = value;
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
        public bool value
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
        public byte radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellIfChance
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellIfTargetRange
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellIfVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellNot
    {

        private object ifIsTargetTopOfThreatListField;

        private MobsMobAIBehaviourIFSelectFirstSpellNotIfSpellActive ifSpellActiveField;

        /// <remarks/>
        public object IfIsTargetTopOfThreatList
        {
            get
            {
                return this.ifIsTargetTopOfThreatListField;
            }
            set
            {
                this.ifIsTargetTopOfThreatListField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourIFSelectFirstSpellNotIfSpellActive IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectFirstSpellNotIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectRandom
    {

        private MobsMobAIBehaviourIFSelectRandomSpell[] spellField;

        private string behaviourField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spell")]
        public MobsMobAIBehaviourIFSelectRandomSpell[] Spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string behaviour
        {
            get
            {
                return this.behaviourField;
            }
            set
            {
                this.behaviourField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectRandomSpell
    {

        private MobsMobAIBehaviourIFSelectRandomSpellEvent eventField;

        private string nameField;

        private string targetField;

        private byte weightField;

        /// <remarks/>
        public MobsMobAIBehaviourIFSelectRandomSpellEvent Event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectRandomSpellEvent
    {

        private MobsMobAIBehaviourIFSelectRandomSpellEventVariable variableField;

        private string typeField;

        /// <remarks/>
        public MobsMobAIBehaviourIFSelectRandomSpellEventVariable Variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSelectRandomSpellEventVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFSpell
    {

        private string nameField;

        private string targetField;

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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFNot
    {

        private MobsMobAIBehaviourIFNotIfSpellActive ifSpellActiveField;

        /// <remarks/>
        public MobsMobAIBehaviourIFNotIfSpellActive IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourIFNotIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandom
    {

        private MobsMobAIBehaviourSelectRandomSpell[] spellField;

        private string behaviourField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Spell")]
        public MobsMobAIBehaviourSelectRandomSpell[] Spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string behaviour
        {
            get
            {
                return this.behaviourField;
            }
            set
            {
                this.behaviourField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandomSpell
    {

        private MobsMobAIBehaviourSelectRandomSpellIfChance ifChanceField;

        private MobsMobAIBehaviourSelectRandomSpellOR orField;

        private string nameField;

        private string targetField;

        private string targetSelectionField;

        private string cooldowngroupField;

        private byte weightField;

        private bool weightFieldSpecified;

        /// <remarks/>
        public MobsMobAIBehaviourSelectRandomSpellIfChance IfChance
        {
            get
            {
                return this.ifChanceField;
            }
            set
            {
                this.ifChanceField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSelectRandomSpellOR or
        {
            get
            {
                return this.orField;
            }
            set
            {
                this.orField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetSelection
        {
            get
            {
                return this.targetSelectionField;
            }
            set
            {
                this.targetSelectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cooldowngroup
        {
            get
            {
                return this.cooldowngroupField;
            }
            set
            {
                this.cooldowngroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool weightSpecified
        {
            get
            {
                return this.weightFieldSpecified;
            }
            set
            {
                this.weightFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandomSpellIfChance
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandomSpellOR
    {

        private MobsMobAIBehaviourSelectRandomSpellORIfOwnHealthPercentage ifOwnHealthPercentageField;

        private MobsMobAIBehaviourSelectRandomSpellORIfFightDuration ifFightDurationField;

        /// <remarks/>
        public MobsMobAIBehaviourSelectRandomSpellORIfOwnHealthPercentage IfOwnHealthPercentage
        {
            get
            {
                return this.ifOwnHealthPercentageField;
            }
            set
            {
                this.ifOwnHealthPercentageField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSelectRandomSpellORIfFightDuration IfFightDuration
        {
            get
            {
                return this.ifFightDurationField;
            }
            set
            {
                this.ifFightDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandomSpellORIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSelectRandomSpellORIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpell
    {

        private object[] itemsField;

        private string nameField;

        private string targetField;

        private string targetSelectionField;

        private decimal cooldowntillnextcastField;

        private bool cooldowntillnextcastFieldSpecified;

        private string cooldowngroupField;

        private string saytextField;

        private byte groundtargetoffsetField;

        private bool groundtargetoffsetFieldSpecified;

        private bool isNewSpellSlotField;

        private bool isNewSpellSlotFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Event", typeof(MobsMobAIBehaviourSpellEvent))]
        [System.Xml.Serialization.XmlElementAttribute("IfChance", typeof(MobsMobAIBehaviourSpellIfChance))]
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobAIBehaviourSpellIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsAnyEnemyInRange", typeof(MobsMobAIBehaviourSpellIfIsAnyEnemyInRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobAIBehaviourSpellIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive", typeof(MobsMobAIBehaviourSpellIfSpellActive))]
        [System.Xml.Serialization.XmlElementAttribute("IfSummonedMobCount", typeof(MobsMobAIBehaviourSpellIfSummonedMobCount))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetHealthPercentage", typeof(MobsMobAIBehaviourSpellIfTargetHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetMobTier", typeof(MobsMobAIBehaviourSpellIfTargetMobTier))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetRange", typeof(MobsMobAIBehaviourSpellIfTargetRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfTotalNumberOfTargetsOnThreatList", typeof(MobsMobAIBehaviourSpellIfTotalNumberOfTargetsOnThreatList))]
        [System.Xml.Serialization.XmlElementAttribute("IfVariable", typeof(MobsMobAIBehaviourSpellIfVariable))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobAIBehaviourSpellNot))]
        [System.Xml.Serialization.XmlElementAttribute("or", typeof(MobsMobAIBehaviourSpellOR))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetSelection
        {
            get
            {
                return this.targetSelectionField;
            }
            set
            {
                this.targetSelectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cooldowntillnextcast
        {
            get
            {
                return this.cooldowntillnextcastField;
            }
            set
            {
                this.cooldowntillnextcastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cooldowntillnextcastSpecified
        {
            get
            {
                return this.cooldowntillnextcastFieldSpecified;
            }
            set
            {
                this.cooldowntillnextcastFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cooldowngroup
        {
            get
            {
                return this.cooldowngroupField;
            }
            set
            {
                this.cooldowngroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string saytext
        {
            get
            {
                return this.saytextField;
            }
            set
            {
                this.saytextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte groundtargetoffset
        {
            get
            {
                return this.groundtargetoffsetField;
            }
            set
            {
                this.groundtargetoffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groundtargetoffsetSpecified
        {
            get
            {
                return this.groundtargetoffsetFieldSpecified;
            }
            set
            {
                this.groundtargetoffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isNewSpellSlot
        {
            get
            {
                return this.isNewSpellSlotField;
            }
            set
            {
                this.isNewSpellSlotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNewSpellSlotSpecified
        {
            get
            {
                return this.isNewSpellSlotFieldSpecified;
            }
            set
            {
                this.isNewSpellSlotFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellEvent
    {

        private MobsMobAIBehaviourSpellEventVariable variableField;

        private MobsMobAIBehaviourSpellEventIF ifField;

        private string typeField;

        /// <remarks/>
        public MobsMobAIBehaviourSpellEventVariable Variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSpellEventIF If
        {
            get
            {
                return this.ifField;
            }
            set
            {
                this.ifField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellEventVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellEventIF
    {

        private MobsMobAIBehaviourSpellEventIFIfVariable ifVariableField;

        private MobsMobAIBehaviourSpellEventIFVariable variableField;

        /// <remarks/>
        public MobsMobAIBehaviourSpellEventIFIfVariable IfVariable
        {
            get
            {
                return this.ifVariableField;
            }
            set
            {
                this.ifVariableField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSpellEventIFVariable Variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellEventIFIfVariable
    {

        private string nameField;

        private string opField;

        private byte valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellEventIFVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfChance
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfFightDuration
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfIsAnyEnemyInRange
    {

        private decimal rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfSummonedMobCount
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfTargetHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfTargetMobTier
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfTargetRange
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfTotalNumberOfTargetsOnThreatList
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellIfVariable
    {

        private string nameField;

        private string opField;

        private bool valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellNot
    {

        private object ifIsTargetTopOfThreatListField;

        private MobsMobAIBehaviourSpellNotIfFightDuration ifFightDurationField;

        private MobsMobAIBehaviourSpellNotIfSpellActive ifSpellActiveField;

        /// <remarks/>
        public object IfIsTargetTopOfThreatList
        {
            get
            {
                return this.ifIsTargetTopOfThreatListField;
            }
            set
            {
                this.ifIsTargetTopOfThreatListField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSpellNotIfFightDuration IfFightDuration
        {
            get
            {
                return this.ifFightDurationField;
            }
            set
            {
                this.ifFightDurationField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSpellNotIfSpellActive IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellNotIfFightDuration
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellNotIfSpellActive
    {

        private string spellField;

        private string whoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellOR
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobAIBehaviourSpellORIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobAIBehaviourSpellORIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive", typeof(MobsMobAIBehaviourSpellORIfSpellActive))]
        [System.Xml.Serialization.XmlElementAttribute("and", typeof(MobsMobAIBehaviourSpellORAnd))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobAIBehaviourSpellORNot))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORAnd
    {

        private MobsMobAIBehaviourSpellORAndIfOwnHealthPercentage ifOwnHealthPercentageField;

        private MobsMobAIBehaviourSpellORAndIfVariable ifVariableField;

        /// <remarks/>
        public MobsMobAIBehaviourSpellORAndIfOwnHealthPercentage IfOwnHealthPercentage
        {
            get
            {
                return this.ifOwnHealthPercentageField;
            }
            set
            {
                this.ifOwnHealthPercentageField = value;
            }
        }

        /// <remarks/>
        public MobsMobAIBehaviourSpellORAndIfVariable IfVariable
        {
            get
            {
                return this.ifVariableField;
            }
            set
            {
                this.ifVariableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORAndIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORAndIfVariable
    {

        private string nameField;

        private string opField;

        private byte valueField;

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
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORNot
    {

        private MobsMobAIBehaviourSpellORNotIfIsAnyFactionMemberInRange ifIsAnyFactionMemberInRangeField;

        /// <remarks/>
        public MobsMobAIBehaviourSpellORNotIfIsAnyFactionMemberInRange IfIsAnyFactionMemberInRange
        {
            get
            {
                return this.ifIsAnyFactionMemberInRangeField;
            }
            set
            {
                this.ifIsAnyFactionMemberInRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIBehaviourSpellORNotIfIsAnyFactionMemberInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIEvents
    {

        private MobsMobAIEventsEvent[] eventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Event")]
        public MobsMobAIEventsEvent[] Event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIEventsEvent
    {

        private MobsMobAIEventsEventSpell spellField;

        private string typeField;

        /// <remarks/>
        public MobsMobAIEventsEventSpell Spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIEventsEventSpell
    {

        private string nameField;

        private string targetField;

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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIVariables
    {

        private MobsMobAIVariablesVar[] varField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Var")]
        public MobsMobAIVariablesVar[] Var
        {
            get
            {
                return this.varField;
            }
            set
            {
                this.varField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAIVariablesVar
    {

        private string nameField;

        private string typeField;

        private string initialValueField;

        private bool resetOnMobResetField;

        private bool resetOnMobResetFieldSpecified;

        private decimal timeToLiveSecondsField;

        private bool timeToLiveSecondsFieldSpecified;

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
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string initialValue
        {
            get
            {
                return this.initialValueField;
            }
            set
            {
                this.initialValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool resetOnMobReset
        {
            get
            {
                return this.resetOnMobResetField;
            }
            set
            {
                this.resetOnMobResetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resetOnMobResetSpecified
        {
            get
            {
                return this.resetOnMobResetFieldSpecified;
            }
            set
            {
                this.resetOnMobResetFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal timeToLiveSeconds
        {
            get
            {
                return this.timeToLiveSecondsField;
            }
            set
            {
                this.timeToLiveSecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeToLiveSecondsSpecified
        {
            get
            {
                return this.timeToLiveSecondsFieldSpecified;
            }
            set
            {
                this.timeToLiveSecondsFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobAssetVfxPreset
    {

        private string nameField;

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
    public partial class MobsMobAudioInfo
    {

        private string nameField;

        private byte threatlevelField;

        private bool threatlevelFieldSpecified;

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
        public byte threatlevel
        {
            get
            {
                return this.threatlevelField;
            }
            set
            {
                this.threatlevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool threatlevelSpecified
        {
            get
            {
                return this.threatlevelFieldSpecified;
            }
            set
            {
                this.threatlevelFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobDeathSpells
    {

        private MobsMobDeathSpellsDeathspell[] deathspellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deathspell")]
        public MobsMobDeathSpellsDeathspell[] deathspell
        {
            get
            {
                return this.deathspellField;
            }
            set
            {
                this.deathspellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobDeathSpellsDeathspell
    {

        private MobsMobDeathSpellsDeathspellIfSpellActive ifSpellActiveField;

        private MobsMobDeathSpellsDeathspellIfTargetRange ifTargetRangeField;

        private string nameField;

        private string targetField;

        private string saytextField;

        private bool killerisinstigatorField;

        private bool killerisinstigatorFieldSpecified;

        /// <remarks/>
        public MobsMobDeathSpellsDeathspellIfSpellActive IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }

        /// <remarks/>
        public MobsMobDeathSpellsDeathspellIfTargetRange IfTargetRange
        {
            get
            {
                return this.ifTargetRangeField;
            }
            set
            {
                this.ifTargetRangeField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string saytext
        {
            get
            {
                return this.saytextField;
            }
            set
            {
                this.saytextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool killerisinstigator
        {
            get
            {
                return this.killerisinstigatorField;
            }
            set
            {
                this.killerisinstigatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool killerisinstigatorSpecified
        {
            get
            {
                return this.killerisinstigatorFieldSpecified;
            }
            set
            {
                this.killerisinstigatorFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobDeathSpellsDeathspellIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobDeathSpellsDeathspellIfTargetRange
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobFootStepVfxPreset
    {

        private string nameField;

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
    public partial class MobsMobLoot
    {

        private object[] itemsField;

        private bool ignoremoblootfactorField;

        private bool ignoremoblootfactorFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Harvestable", typeof(MobsMobLootHarvestable))]
        [System.Xml.Serialization.XmlElementAttribute("Item", typeof(MobsMobLootItem))]
        [System.Xml.Serialization.XmlElementAttribute("LootListReference", typeof(MobsMobLootLootListReference))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoremoblootfactor
        {
            get
            {
                return this.ignoremoblootfactorField;
            }
            set
            {
                this.ignoremoblootfactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoremoblootfactorSpecified
        {
            get
            {
                return this.ignoremoblootfactorFieldSpecified;
            }
            set
            {
                this.ignoremoblootfactorFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobLootHarvestable
    {

        private string typeField;

        private byte tierField;

        private decimal chanceField;

        private bool chanceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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
        public decimal chance
        {
            get
            {
                return this.chanceField;
            }
            set
            {
                this.chanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chanceSpecified
        {
            get
            {
                return this.chanceFieldSpecified;
            }
            set
            {
                this.chanceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobLootItem
    {

        private string typeField;

        private decimal chanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal chance
        {
            get
            {
                return this.chanceField;
            }
            set
            {
                this.chanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobLootLootListReference
    {

        private string nameField;

        private decimal chanceField;

        private bool chanceFieldSpecified;

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
        public decimal chance
        {
            get
            {
                return this.chanceField;
            }
            set
            {
                this.chanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool chanceSpecified
        {
            get
            {
                return this.chanceFieldSpecified;
            }
            set
            {
                this.chanceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobMinimapDisplay
    {

        private string minimapmarkerField;

        private string minimapalarmmarkerField;

        private byte minimumalarmtimesecondsField;

        private bool minimumalarmtimesecondsFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minimapmarker
        {
            get
            {
                return this.minimapmarkerField;
            }
            set
            {
                this.minimapmarkerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minimapalarmmarker
        {
            get
            {
                return this.minimapalarmmarkerField;
            }
            set
            {
                this.minimapalarmmarkerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte minimumalarmtimeseconds
        {
            get
            {
                return this.minimumalarmtimesecondsField;
            }
            set
            {
                this.minimumalarmtimesecondsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool minimumalarmtimesecondsSpecified
        {
            get
            {
                return this.minimumalarmtimesecondsFieldSpecified;
            }
            set
            {
                this.minimumalarmtimesecondsFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSocketPreset
    {

        private string nameField;

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
    public partial class MobsMobSpawnSpells
    {

        private MobsMobSpawnSpellsSpawnspell spawnspellField;

        /// <remarks/>
        public MobsMobSpawnSpellsSpawnspell spawnspell
        {
            get
            {
                return this.spawnspellField;
            }
            set
            {
                this.spawnspellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpawnSpellsSpawnspell
    {

        private string nameField;

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
    public partial class MobsMobSpells
    {

        private MobsMobSpellsSpell[] spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("spell")]
        public MobsMobSpellsSpell[] spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpell
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string nameField;

        private string targetField;

        private byte groundtargetoffsetField;

        private bool groundtargetoffsetFieldSpecified;

        private string cooldowngroupField;

        private decimal cooldowntillnextcastField;

        private bool cooldowntillnextcastFieldSpecified;

        private string saytextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfChance", typeof(MobsMobSpellsSpellIfChance))]
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobSpellsSpellIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsAnyEnemyInRange", typeof(MobsMobSpellsSpellIfIsAnyEnemyInRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsAnyFactionMemberInRange", typeof(MobsMobSpellsSpellIfIsAnyFactionMemberInRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsTargetCasting", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("IfIsTargetTopOfThreatList", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobSpellsSpellIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive", typeof(MobsMobSpellsSpellIfSpellActive))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellCategoryActive", typeof(MobsMobSpellsSpellIfSpellCategoryActive))]
        [System.Xml.Serialization.XmlElementAttribute("IfSummonedMobCount", typeof(MobsMobSpellsSpellIfSummonedMobCount))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetEnergyPercentage", typeof(MobsMobSpellsSpellIfTargetEnergyPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetHealthPercentage", typeof(MobsMobSpellsSpellIfTargetHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetRange", typeof(MobsMobSpellsSpellIfTargetRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetTookDamage", typeof(MobsMobSpellsSpellIfTargetTookDamage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetWeaponTypeEquipped", typeof(MobsMobSpellsSpellIfTargetWeaponTypeEquipped))]
        [System.Xml.Serialization.XmlElementAttribute("IfTotalNumberOfTargetsOnThreatList", typeof(MobsMobSpellsSpellIfTotalNumberOfTargetsOnThreatList))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobSpellsSpellNot))]
        [System.Xml.Serialization.XmlElementAttribute("or", typeof(MobsMobSpellsSpellOR))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
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
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte groundtargetoffset
        {
            get
            {
                return this.groundtargetoffsetField;
            }
            set
            {
                this.groundtargetoffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groundtargetoffsetSpecified
        {
            get
            {
                return this.groundtargetoffsetFieldSpecified;
            }
            set
            {
                this.groundtargetoffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cooldowngroup
        {
            get
            {
                return this.cooldowngroupField;
            }
            set
            {
                this.cooldowngroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cooldowntillnextcast
        {
            get
            {
                return this.cooldowntillnextcastField;
            }
            set
            {
                this.cooldowntillnextcastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cooldowntillnextcastSpecified
        {
            get
            {
                return this.cooldowntillnextcastFieldSpecified;
            }
            set
            {
                this.cooldowntillnextcastFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string saytext
        {
            get
            {
                return this.saytextField;
            }
            set
            {
                this.saytextField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfChance
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfFightDuration
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfIsAnyEnemyInRange
    {

        private decimal rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfIsAnyFactionMemberInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfSpellCategoryActive
    {

        private string whoField;

        private string categoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfSummonedMobCount
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTargetEnergyPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTargetHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTargetRange
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTargetTookDamage
    {

        private string damageTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DamageType
        {
            get
            {
                return this.damageTypeField;
            }
            set
            {
                this.damageTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTargetWeaponTypeEquipped
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellIfTotalNumberOfTargetsOnThreatList
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNot
    {

        private MobsMobSpellsSpellNotIfIsAnyEnemyInRange ifIsAnyEnemyInRangeField;

        private MobsMobSpellsSpellNotIfSummonedMobCount ifSummonedMobCountField;

        private object ifIsTargetTopOfThreatListField;

        private MobsMobSpellsSpellNotOR orField;

        private MobsMobSpellsSpellNotIfSpellActive[] ifSpellActiveField;

        private MobsMobSpellsSpellNotIfOwnHealthPercentage ifOwnHealthPercentageField;

        private MobsMobSpellsSpellNotIfIsAnyFactionMemberInRange ifIsAnyFactionMemberInRangeField;

        private MobsMobSpellsSpellNotIfFightDuration ifFightDurationField;

        /// <remarks/>
        public MobsMobSpellsSpellNotIfIsAnyEnemyInRange IfIsAnyEnemyInRange
        {
            get
            {
                return this.ifIsAnyEnemyInRangeField;
            }
            set
            {
                this.ifIsAnyEnemyInRangeField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotIfSummonedMobCount IfSummonedMobCount
        {
            get
            {
                return this.ifSummonedMobCountField;
            }
            set
            {
                this.ifSummonedMobCountField = value;
            }
        }

        /// <remarks/>
        public object IfIsTargetTopOfThreatList
        {
            get
            {
                return this.ifIsTargetTopOfThreatListField;
            }
            set
            {
                this.ifIsTargetTopOfThreatListField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotOR or
        {
            get
            {
                return this.orField;
            }
            set
            {
                this.orField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive")]
        public MobsMobSpellsSpellNotIfSpellActive[] IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotIfOwnHealthPercentage IfOwnHealthPercentage
        {
            get
            {
                return this.ifOwnHealthPercentageField;
            }
            set
            {
                this.ifOwnHealthPercentageField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotIfIsAnyFactionMemberInRange IfIsAnyFactionMemberInRange
        {
            get
            {
                return this.ifIsAnyFactionMemberInRangeField;
            }
            set
            {
                this.ifIsAnyFactionMemberInRangeField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotIfFightDuration IfFightDuration
        {
            get
            {
                return this.ifFightDurationField;
            }
            set
            {
                this.ifFightDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfIsAnyEnemyInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfSummonedMobCount
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotOR
    {

        private MobsMobSpellsSpellNotORIfIsAnyEnemyInRange ifIsAnyEnemyInRangeField;

        private object ifIsTargetTopOfThreatListField;

        private MobsMobSpellsSpellNotORIfFightDuration ifFightDurationField;

        private MobsMobSpellsSpellNotORIfSpellActive[] ifSpellActiveField;

        private MobsMobSpellsSpellNotORIfIsAnyFactionMemberInRange ifIsAnyFactionMemberInRangeField;

        private MobsMobSpellsSpellNotORIfSummonedMobCount ifSummonedMobCountField;

        private MobsMobSpellsSpellNotORIfTargetWeaponTypeEquipped[] ifTargetWeaponTypeEquippedField;

        /// <remarks/>
        public MobsMobSpellsSpellNotORIfIsAnyEnemyInRange IfIsAnyEnemyInRange
        {
            get
            {
                return this.ifIsAnyEnemyInRangeField;
            }
            set
            {
                this.ifIsAnyEnemyInRangeField = value;
            }
        }

        /// <remarks/>
        public object IfIsTargetTopOfThreatList
        {
            get
            {
                return this.ifIsTargetTopOfThreatListField;
            }
            set
            {
                this.ifIsTargetTopOfThreatListField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotORIfFightDuration IfFightDuration
        {
            get
            {
                return this.ifFightDurationField;
            }
            set
            {
                this.ifFightDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive")]
        public MobsMobSpellsSpellNotORIfSpellActive[] IfSpellActive
        {
            get
            {
                return this.ifSpellActiveField;
            }
            set
            {
                this.ifSpellActiveField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotORIfIsAnyFactionMemberInRange IfIsAnyFactionMemberInRange
        {
            get
            {
                return this.ifIsAnyFactionMemberInRangeField;
            }
            set
            {
                this.ifIsAnyFactionMemberInRangeField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellNotORIfSummonedMobCount IfSummonedMobCount
        {
            get
            {
                return this.ifSummonedMobCountField;
            }
            set
            {
                this.ifSummonedMobCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfTargetWeaponTypeEquipped")]
        public MobsMobSpellsSpellNotORIfTargetWeaponTypeEquipped[] IfTargetWeaponTypeEquipped
        {
            get
            {
                return this.ifTargetWeaponTypeEquippedField;
            }
            set
            {
                this.ifTargetWeaponTypeEquippedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfIsAnyEnemyInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfIsAnyFactionMemberInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfSummonedMobCount
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotORIfTargetWeaponTypeEquipped
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfIsAnyFactionMemberInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellNotIfFightDuration
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellOR
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfFightDuration", typeof(MobsMobSpellsSpellORIfFightDuration))]
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage", typeof(MobsMobSpellsSpellORIfOwnHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfSpellActive", typeof(MobsMobSpellsSpellORIfSpellActive))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetHealthPercentage", typeof(MobsMobSpellsSpellORIfTargetHealthPercentage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetIsInOpposingFaction", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetRange", typeof(MobsMobSpellsSpellORIfTargetRange))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetTookDamage", typeof(MobsMobSpellsSpellORIfTargetTookDamage))]
        [System.Xml.Serialization.XmlElementAttribute("IfTargetWeaponTypeEquipped", typeof(MobsMobSpellsSpellORIfTargetWeaponTypeEquipped))]
        [System.Xml.Serialization.XmlElementAttribute("and", typeof(MobsMobSpellsSpellORAnd))]
        [System.Xml.Serialization.XmlElementAttribute("not", typeof(MobsMobSpellsSpellORNot))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfFightDuration
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfSpellActive
    {

        private string whoField;

        private string spellField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string who
        {
            get
            {
                return this.whoField;
            }
            set
            {
                this.whoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spell
        {
            get
            {
                return this.spellField;
            }
            set
            {
                this.spellField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfTargetHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfTargetRange
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfTargetTookDamage
    {

        private string damageTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DamageType
        {
            get
            {
                return this.damageTypeField;
            }
            set
            {
                this.damageTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORIfTargetWeaponTypeEquipped
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORAnd
    {

        private MobsMobSpellsSpellORAndIfOwnHealthPercentage[] ifOwnHealthPercentageField;

        private MobsMobSpellsSpellORAndNot notField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IfOwnHealthPercentage")]
        public MobsMobSpellsSpellORAndIfOwnHealthPercentage[] IfOwnHealthPercentage
        {
            get
            {
                return this.ifOwnHealthPercentageField;
            }
            set
            {
                this.ifOwnHealthPercentageField = value;
            }
        }

        /// <remarks/>
        public MobsMobSpellsSpellORAndNot not
        {
            get
            {
                return this.notField;
            }
            set
            {
                this.notField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORAndIfOwnHealthPercentage
    {

        private string opField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORAndNot
    {

        private MobsMobSpellsSpellORAndNotIfSummonedMobCount ifSummonedMobCountField;

        /// <remarks/>
        public MobsMobSpellsSpellORAndNotIfSummonedMobCount IfSummonedMobCount
        {
            get
            {
                return this.ifSummonedMobCountField;
            }
            set
            {
                this.ifSummonedMobCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORAndNotIfSummonedMobCount
    {

        private string opField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string op
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORNot
    {

        private MobsMobSpellsSpellORNotIfIsAnyFactionMemberInRange ifIsAnyFactionMemberInRangeField;

        /// <remarks/>
        public MobsMobSpellsSpellORNotIfIsAnyFactionMemberInRange IfIsAnyFactionMemberInRange
        {
            get
            {
                return this.ifIsAnyFactionMemberInRangeField;
            }
            set
            {
                this.ifIsAnyFactionMemberInRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobSpellsSpellORNotIfIsAnyFactionMemberInRange
    {

        private byte rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        IfChance,

        /// <remarks/>
        IfFightDuration,

        /// <remarks/>
        IfIsAnyEnemyInRange,

        /// <remarks/>
        IfIsAnyFactionMemberInRange,

        /// <remarks/>
        IfIsTargetCasting,

        /// <remarks/>
        IfIsTargetTopOfThreatList,

        /// <remarks/>
        IfOwnHealthPercentage,

        /// <remarks/>
        IfSpellActive,

        /// <remarks/>
        IfSpellCategoryActive,

        /// <remarks/>
        IfSummonedMobCount,

        /// <remarks/>
        IfTargetEnergyPercentage,

        /// <remarks/>
        IfTargetHealthPercentage,

        /// <remarks/>
        IfTargetRange,

        /// <remarks/>
        IfTargetTookDamage,

        /// <remarks/>
        IfTargetWeaponTypeEquipped,

        /// <remarks/>
        IfTotalNumberOfTargetsOnThreatList,

        /// <remarks/>
        not,

        /// <remarks/>
        or,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobProjectile
    {

        private object[] itemsField;

        private string prefabField;

        private string startsocketField;

        private string hitsocketField;

        private decimal flyspeedField;

        private bool flyspeedFieldSpecified;

        private decimal timeoffsetField;

        private bool timeoffsetFieldSpecified;

        private bool ignoresocketscaleField;

        private bool ignoresocketscaleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AudioInfo", typeof(MobsMobProjectileAudioInfo))]
        [System.Xml.Serialization.XmlElementAttribute("impactvfx", typeof(MobsMobProjectileImpactvfx))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefab
        {
            get
            {
                return this.prefabField;
            }
            set
            {
                this.prefabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startsocket
        {
            get
            {
                return this.startsocketField;
            }
            set
            {
                this.startsocketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hitsocket
        {
            get
            {
                return this.hitsocketField;
            }
            set
            {
                this.hitsocketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal flyspeed
        {
            get
            {
                return this.flyspeedField;
            }
            set
            {
                this.flyspeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flyspeedSpecified
        {
            get
            {
                return this.flyspeedFieldSpecified;
            }
            set
            {
                this.flyspeedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal timeoffset
        {
            get
            {
                return this.timeoffsetField;
            }
            set
            {
                this.timeoffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeoffsetSpecified
        {
            get
            {
                return this.timeoffsetFieldSpecified;
            }
            set
            {
                this.timeoffsetFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoresocketscale
        {
            get
            {
                return this.ignoresocketscaleField;
            }
            set
            {
                this.ignoresocketscaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoresocketscaleSpecified
        {
            get
            {
                return this.ignoresocketscaleFieldSpecified;
            }
            set
            {
                this.ignoresocketscaleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MobsMobProjectileAudioInfo
    {

        private string nameField;

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
    public partial class MobsMobProjectileImpactvfx
    {

        private string prefabField;

        private string impactsocketField;

        private string constraintpresetField;

        private decimal sizeField;

        private bool sizeFieldSpecified;

        private bool ignoresocketscaleField;

        private bool ignoresocketscaleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefab
        {
            get
            {
                return this.prefabField;
            }
            set
            {
                this.prefabField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string impactsocket
        {
            get
            {
                return this.impactsocketField;
            }
            set
            {
                this.impactsocketField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string constraintpreset
        {
            get
            {
                return this.constraintpresetField;
            }
            set
            {
                this.constraintpresetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }
            set
            {
                this.sizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoresocketscale
        {
            get
            {
                return this.ignoresocketscaleField;
            }
            set
            {
                this.ignoresocketscaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ignoresocketscaleSpecified
        {
            get
            {
                return this.ignoresocketscaleFieldSpecified;
            }
            set
            {
                this.ignoresocketscaleFieldSpecified = value;
            }
        }
    }


}
