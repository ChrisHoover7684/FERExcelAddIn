using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FERExcelAddIn.Resources;

namespace FERExcelAddIn.Resources
{
    public enum Phase
    {
        Gas,
        Liquid,
        TwoPhase,
        Steam
    }

    public static class MaterialDatabase
    {
        public static readonly Dictionary<string, MaterialProperties> Materials =
            new Dictionary<string, MaterialProperties>(StringComparer.OrdinalIgnoreCase)
        {
        // ================= GASES =================
        {
            "Air",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.97,
                SpecificHeatRatio = 1.40,
                Compressibility = 0.99,
                Viscosity = 0.018,
                SpecificGravity = 1.00,
                DefaultTemperature = 25,
                IsSpecialCase = true
            }
        },
        {
            "Nitrogen (N₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.01,
                SpecificHeatRatio = 1.40,
                Compressibility = 0.99,
                Viscosity = 0.017,
                SpecificGravity = 0.97,
                DefaultTemperature = 25
            }
        },
        {
            "Hydrogen (H₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 2.02,
                SpecificHeatRatio = 1.41,
                Compressibility = 1.01,
                Viscosity = 0.009,
                SpecificGravity = 0.07,
                DefaultTemperature = 25
            }
        },
        {
            "Methane (CH₄)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 16.04,
                SpecificHeatRatio = 1.31,
                Compressibility = 0.95,
                Viscosity = 0.011,
                SpecificGravity = 0.55,
                DefaultTemperature = 25
            }
        },
        {
            "Carbon Dioxide (CO₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 44.01,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.94,
                Viscosity = 0.015,
                SpecificGravity = 1.52,
                DefaultTemperature = 25
            }
        },

        // ================= LIQUIDS =================
        {
            "Water",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 18.02,
                SpecificGravity = 1.00,
                Viscosity = 1.00,
                VaporPressure = 0.46,
                BoilingPoint = 100,
                DefaultTemperature = 25,
                LatentHeatOfVaporization = 970 // BTU/lb for water at 212°F
            }
        },
        {
            "Gasoline",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 110.0,
                SpecificGravity = 0.74,
                Viscosity = 0.6,
                VaporPressure = 10.0,
                BoilingPoint = 150,
                DefaultTemperature = 25
            }
        },
        {
            "Diesel",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 200.0,
                SpecificGravity = 0.85,
                Viscosity = 3.0,
                VaporPressure = 0.01,
                BoilingPoint = 250,
                DefaultTemperature = 25
            }
        },
        {
            "Crude Oil (Medium)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 250.0,
                SpecificGravity = 0.87,
                Viscosity = 15.0,
                VaporPressure = 2.0,
                BoilingPoint = 300,
                DefaultTemperature = 25
            }
        },

        // ================= TWO-PHASE SYSTEMS =================
        {
            "LPG (Propane/Butane Mix)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 50.0,
                SpecificHeatRatio = 1.11,
                SpecificGravityLiquid = 0.54,
                SpecificGravityVapor = 1.75,
                Viscosity = 0.008,
                BubblePoint = -20,
                DefaultTemperature = 25
            }
        },
        {
            "Ammonia (Saturated)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 17.03,
                SpecificHeatRatio = 1.33,
                SpecificGravityLiquid = 0.68,
                SpecificGravityVapor = 0.59,
                Viscosity = 0.010,
                BubblePoint = -33,
                DefaultTemperature = 25
            }
            },

            {"CO₂ (Saturated)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 44.01,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.94,
                Viscosity = 0.015,
                SpecificGravityLiquid = 0.82,
                SpecificGravityVapor = 1.52,
                BubblePoint = -78.5,  // Sublimation point
                DefaultTemperature = -20
            }
        },

        // ================= STEAM =================
        {
            "Low Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.33,
                Compressibility = 0.99,
                Viscosity = 0.013,
                DefaultTemperature = 120
            }
        },
        {
            "Medium Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.3,
                Compressibility = 0.97,
                Viscosity = 0.018,
                DefaultTemperature = 180
            }
        },
        {
            "High Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.95,
                Viscosity = 0.025,
                DefaultTemperature = 250
            }
        },

        // ================= HYDROCARBONS =================
        {
            "Propane",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 44.1,
                SpecificHeatRatio = 1.13,
                Compressibility = 0.9,
                Viscosity = 0.008,
                SpecificGravity = 1.52,
                DefaultTemperature = 25
            }
        },
        {
            "Butane",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 58.12,
                SpecificHeatRatio = 1.09,
                Compressibility = 0.85,
                Viscosity = 0.007,
                SpecificGravity = 2.01,
                DefaultTemperature = 25
            }
        },
        {
            "Ethylene",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.05,
                SpecificHeatRatio = 1.24,
                Compressibility = 0.98,
                Viscosity = 0.01,
                SpecificGravity = 0.97,
                DefaultTemperature = 25
            }
        },
        {
            "Propylene",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 42.08,
                SpecificHeatRatio = 1.15,
                Compressibility = 0.92,
                Viscosity = 0.008,
                SpecificGravity = 1.45,
                DefaultTemperature = 25
            }
        },

        // ================= CHEMICALS =================
        {
            "Chlorine",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 70.9,
                SpecificHeatRatio = 1.36,
                Compressibility = 0.95,
                Viscosity = 0.013,
                SpecificGravity = 2.48,
                DefaultTemperature = 25
            }
        },
        {
            "Vinyl Chloride",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 62.5,
                SpecificHeatRatio = 1.2,
                Compressibility = 0.94,
                Viscosity = 0.01,
                SpecificGravity = 2.16,
                DefaultTemperature = 25
            }
        }
    };

        public class MaterialProperties
        {
            public Phase Type { get; set; }
            public double MolecularWeight { get; set; }  // g/mol

            // Gas properties
            public double SpecificHeatRatio { get; set; } = 1.0; // k = Cp/Cv
            public double Compressibility { get; set; } = 1.0;   // Z
            public double SpecificGravity { get; set; } = 1.0;   // vs air for gases

            // Liquid properties
            public double VaporPressure { get; set; }    // psia
            public double BoilingPoint { get; set; }     // °C
            public double SpecificGravityLiquid { get; set; } = 1.0; // vs water

            // Two-phase properties
            public double SpecificGravityVapor { get; set; }
            public double BubblePoint { get; set; }      // °C

            // Common
            public double Viscosity { get; set; }       // cP
            public int DefaultTemperature { get; set; } // °C

            public bool IsSpecialCase { get; set; } = false;

            // Added property
            public double LatentHeatOfVaporization { get; set; } // BTU/lb
        }
    }
}
