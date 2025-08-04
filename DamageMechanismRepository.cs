using System;
using System.Collections.Generic;
using System.Linq;

namespace FERExcelAddIn
{
    public static class DamageMechanismRepository
    {
        private static readonly Dictionary<string, DamageMechanism> _mechanisms = new Dictionary<string, DamageMechanism>(StringComparer.OrdinalIgnoreCase);

        static DamageMechanismRepository()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            AddMechanism(new DamageMechanism
            {
                Name = "Chloride Stress Corrosion Cracking",
                Description = "Cracking of 300 series SS under tensile stress in chloride environments.",
                AffectedMaterials = "300 series SS, duplex SS, nickel alloys",
                AffectedUnits = "Heat exchangers, piping, vessels",
                CriticalFactors = "Chloride content, temperature > 60°C, pH, tensile stress",
                Prevention = "Use resistant alloys, avoid chlorides, proper insulation",
                Inspection = "PT, UT, ECT",
                RiskLevel = "High",
                RelatedMechanisms = new List<string> { "Caustic SCC", "Polythionic Acid SCC" }
            });
        }

        private static void AddMechanism(DamageMechanism mechanism)
        {
            if (!_mechanisms.ContainsKey(mechanism.Name))
            {
                _mechanisms.Add(mechanism.Name, mechanism);
            }
        }

        public static DamageMechanism GetMechanism(string name)
        {
            return _mechanisms.TryGetValue(name, out var mechanism) ? mechanism : null;
        }

        public static List<DamageMechanism> GetAllMechanisms()
        {
            return _mechanisms.Values.OrderBy(m => m.Name).ToList();
        }

        public static List<string> GetAllMaterials()
        {
            return _mechanisms.Values
                .SelectMany(m => m.AffectedMaterials.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(m => m.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(m => m)
                .ToList();
        }

        public static List<string> GetAllUnits()
        {
            return _mechanisms.Values
                .SelectMany(m => m.AffectedUnits.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(u => u.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(u => u)
                .ToList();
        }

        public static List<DamageMechanism> SearchMechanisms(string searchTerm = "", string materialFilter = "", string unitFilter = "")
        {
            var query = _mechanisms.Values.AsEnumerable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(m => m.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                        m.Description.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrEmpty(materialFilter))
            {
                query = query.Where(m => m.AffectedMaterials.IndexOf(materialFilter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrEmpty(unitFilter))
            {
                query = query.Where(m => m.AffectedUnits.IndexOf(unitFilter, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return query.OrderBy(m => m.Name).ToList();
        }
    }
}