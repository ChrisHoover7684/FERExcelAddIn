using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FERExcelAddIn
{
    /// <summary>
    /// Provides access to ASME B31.3-2024 notes with lookup functionality
    /// </summary>
    public static class ASMEB31_3Notes2024
    {
        /// <summary>
        /// Dictionary containing all ASME B31.3-2024 notes
        /// </summary>
        public static readonly IReadOnlyDictionary<string, string> Notes =
    new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
        {
            // General Notes
            {"(a)", "The allowable stress values, P-Number assignments, and minimum temperatures, together with the referenced Notes in the stress tables, are requirements of this Code."},
            {"(b)", "Notes (1) through (7) are referenced in column headings and in body headings for material type and product form; Note (8) and all subsequent Notes are referenced in the Notes column for specific materials. Notes marked with an asterisk (*) restate requirements found in the text of the Code."},
            {"(c)", "The stress values given in MPa as shown in Table A-1, and given in ksi as shown in Table A-1C, may be used. The values stated in ksi are not exact equivalents to the values stated in MPa."},
            {"(d)", "For copper and copper alloys, the following symbols are used in the Temper column: H = drawn; H01 = quarter hard; H02 = half hard; H06 = extra hard; H55 = light drawn; H58 = drawn, general purpose; H80 = hard drawn; HR50 = drawn, stress relieved; M20 = hot rolled; O25 = hot rolled, annealed; O50 = light annealed; O60 = soft annealed; O61 = annealed; W050 = welded, annealed; and W061 = welded, fully finished, annealed."},
            {"(e)", "For nickel and nickel alloys, the following abbreviations are used in the Class column: ann, annealed; CD, cold worked; forg, forged; H.F., hot finished; H.R., hot rolled; H.W., hot worked; plt, plate; R, rolled; rel, relieved; sol, solution; str, stress; and tr, treated."},
            {"(f)", "In Table A-1, the following abbreviations are used in the Product Form column: CW, continuous welded; EW, electric welded; forg, forgings; fg, fittings; pl, plate; sbps, shapes; sht, sheet; smls, seamless; struct, structural; and wld, welded."},

            // Numbered Notes
            {"1", "*The stress values are basic allowable stresses in tension in accordance with para. 302.3.1(a). For pressure design, the stress values are multiplied by the appropriate quality factor E(E_f from Table A-2 or E_f from Table A-3). Stress values in shear and bearing are stated in para. 302.3.1(b); those in compression in para. 302.3.1(c)."},
            {"2a", "*In Table A-1C, stress values printed in italics exceed two-thirds of the expected yield strength at temperature. Stress values in boldface are equal to 90% of expected yield strength at temperature. See paras. 302.3.2(d)(3) and 302.3.2(e)."},
            {"2b", "*In Table A-1, stress values printed in italics are tensile-controlled values. Yield-controlled stress values are in normal font and time-dependent stress values are in boldface."},
            {"3", "The stress values for austenitic stainless steels in these Tables may not be applicable if the material has been given a final heat treatment other than that required by the material specification or by reference to Note (30) or Note (31)."},
            {"4", "Reserved"},
            {"5", "*See ASME BPVC, Section IX, QW-200.3 for a description of P-Number groupings. P-Numbers are indicated by number or by a number followed by a letter (e.g., 8, 5B, or 11A)."},
            {"6", "*The minimum temperature shown is that design minimum temperature for which the material is normally suitable without impact testing other than that required by the material specification. However, the use of a material at a design minimum temperature colder than -29°C (-20°F) is established by rules elsewhere in this Code, including para. 323.2.2 and other impact test requirements."},
            {"7", "The letter 'a' indicates alloys that are not recommended for welding and that, if welded, shall be individually qualified. The letter 'b' indicates copper base alloys that shall be individually qualified."},
            {"8", "*There are restrictions on the use of this material in the text of the Code as follows:\n(a) See para. 305.2.1; temperature limits are -29°C to 186°C (-20°F to 366°F);\n(b) See para. 305.2.2; pipe shall be safeguarded when used outside the temperature limits in Note (8a).\n(c) See Table 323.2.2-1, box B-2.\n(d) See para. 323.4.2(a).\n(e) See para. 323.4.2(b)."},
            {"9", "*For pressure-temperature ratings of components made in accordance with standards listed in Table 326.1.1-1, see para. 326.2.1. Stress values may be used to calculate ratings for unlisted components, and special ratings for listed components, as permitted by para. 303."},
            {"10", "Component standards listed in Table 326.1.1-1 impose the following restrictions on this material when used as a forging: composition, properties, heat treatment, and grain size shall conform to this specification; manufacturing procedures, tolerances, tests, certification, and markings shall be in accordance with ASTM B564."},
            {"11", "*For use under this Code, radiography shall be performed after heat treatment."},
            {"12", "*Certain forms of this material, as stated in Table 323.2.2-1, shall be impact tested to qualify for service below -29°C (-20°F). Alternatively, if provisions for impact testing are included in the material specification as supplementary requirements and are invoked, the material may be used down to the temperature at which the test was conducted in accordance with the specification."},
            {"13", "Properties of this material vary with thickness or size. Stress values are based on minimum properties for the thickness listed."},
            {"14", "For use in Code piping at the stated stress values, the required minimum tensile and yield properties must be verified by tensile test. If such tests are not required by the material specification, they shall be specified in the purchase order."},
            {"15", "For service temperature >454°C (850°F), weld metal shall have a carbon content >0.05%."},
            {"16", "Heat treatment is required after welding for all products of zirconium Grade R60705. See Table 331.1.1-1."},
            {"17", "Mechanical properties of fittings made from forging stock shall meet the minimum tensile requirements of one of the bar, forging, or rod specifications listed in Table 2 of B366 for which tensile testing is required."},
            {"18", "Stress values shown are for materials in the normalized and tempered condition, or when the heat treatment is unknown. If material is annealed, use the following values above 510°C (950°F):\n538°C (1,000°F): 55.1 MPa (8.0 ksi)\n566°C (1,050°F): 39.3 MPa (5.7 ksi)\n593°C (1,100°F): 26.2 MPa (3.8 ksi)\n621°C (1,150°F): 16.5 MPa (2.4 ksi)\n649°C (1,200°F): 9.6 MPa (1.4 ksi)"},
            {"19", "The minimum tensile strength of the reduced section tensile specimen in accordance with ASME BPVC, Section IX, QW-462.1, shall not be less than 758 MPa (110.0 ksi)."},
            {"20", "For pipesizes ≥DN 200 (≥NPS 8) with wall thicknesses ≥Sch 140, the specified minimum tensile strength is 483 MPa (70 ksi)."},
            {"21", "For material thickness >130 mm (>5 in.), the specified minimum tensile strength is 485 MPa (70 ksi)."},
            {"22", "The minimum tensile strength for weld (qualification) and stress values shown shall be multiplied by 0.90 for pipe having an outside diameter less than 51 mm (2.0 in.) and a D/t value less than 15."},
            {"23", "For material thickness >130 mm (>5 in.), the specified minimum tensile strength is 450 MPa (65 ksi)."},
            {"24", "Yield strength is not stated in the material specification. The value shown is based on yield strengths of materials with similar characteristics."},
            {"25", "This steel may develop embrittlement after service at approximately 316°C (600°F) and higher temperature."},
            {"26", "This unstabilized grade of stainless steel increasingly tends to precipitate intergranular carbides as the carbon content increases above 0.03%. See also para. F323.4(c)(2)."},
            {"27", "For temperatures above 427°C (800°F), these stress values apply only when the carbon content is 0.04% or higher."},
            {"28", "For temperatures above 538°C (1,000°F), these stress values apply only when the carbon content is 0.04% or higher."},
            {"29", "The stress values above 538°C (1,000°F) listed here shall be used only when the steel's austenitic micrograin size, as defined in ASTM E112, is No. 6 or less (coarser grain). Otherwise, the lower stress values listed for the same material, specification, and grade shall be used."},
            {"30", "For temperatures above 538°C (1,000°F), these stress values may be used only if the material has been heat treated by heating to a minimum temperature of 1,093°C (2,000°F) and quenching in water or rapidly cooling by other means."},
            {"31", "For temperatures above 538°C (1,000°F), these stress values may be used only if the material has been heat treated by heating to a minimum temperature of 1,038°C (1,900°F) and quenching in water or rapidly cooling by other means."},
            {"32", "Stress values shown are for the lowest strength base material permitted by the specification to be used in the manufacture of this grade of fitting. If a higher strength base material is used, the higher stress values for that material may be used in design."},
            {"33", "For welded construction with work hardened grades, use the stress values for annealed material; for welded construction with precipitation hardened grades, use the special stress values for welded construction given in the tables."},
            {"34", "If material is welded, brazed, or soldered, the allowable stress values for the annealed condition shall be used."},
            {"35", "This steel is intended for use at high temperatures; it may have low ductility and/or low impact properties at room temperature after being used above the temperature indicated by para. F323.4(c)(4)."},
            {"36", "The specification permits this material to be furnished without solution heat treatment or with other than a solution heat treatment. When the material has not been solution heat treated, the minimum temperature shall be -29°C (-20°F) unless the material is impacted in accordance with para. 323.3."},
            {"37", "Impact requirements for seamless fittings shall be governed by those listed in this table for the particular base material specification in the grades permitted (A312, A240, and A182). When A276 materials are used in the manufacture of these fittings, the Notes, minimum temperatures, and allowable stresses for comparable grades of A240 materials shall apply."},
            {"38", "For use under this Code, impact testing shall be performed in accordance with para. 323.3 at the design minimum temperature but not warmer than -29°C (-20°F)."},
            {"39", "This material when used below -29°C (-20°F) shall be impact tested if the carbon content is above 0.10%."},
            {"40", "Stress values shown are 90% of those for the corresponding core material."},
            {"41", "The tension test specimen from plate 12.7 mm (½ in.) and thicker is machined from the core and does not include the cladding alloy; therefore, the stress values listed are those for materials less than 12.7 mm."},
            {"42", "This material may be used only in nonpressure applications."},
            {"43", "*The stress values given for this material are not applicable when either welding or thermal cutting is employed [see para. 323.4.2(c)]."},
            {"44", "For stress relieved tempers (T351, T3510, T3511, T451, T4510, T4511, T651, T6510, T6511), stress values for material in the listed temper shall be used."},
            {"45", "Stress values shown are applicable for 'die' forgings only."},
            {"46", "The minimum temperature shown is for the heaviest wall meeting the specified mechanical property requirements in the specification. The minimum temperature for lighter walls shall be as shown in the following tabulation:\nA203 A/B: -68°C/-90°F (≤51 mm/2 in.), -59°C/-75°F (51-76 mm/2-3 in.)\nA203 D/E: -101°C/-150°F (≤51 mm/2 in.), -87°C/-125°F (51-76 mm/2-3 in.)"},
            {"47", "If no welding is employed in fabrication of piping from these materials, the stress values may be increased to 230 MPa (33.3 ksi)."},
            {"48", "The stress value to be used for this gray iron material at its upper temperature limit of 232°C (450°F) is the same as that shown in the 204°C (400°F) column."},
            {"49", "If the chemical composition of this Grade is such as to render it hardenable, qualification under P-No. 6 is required."},
            {"50", "This material is grouped in P-No. 7 because its hardenability is low."},
            {"51", "This material may require special consideration for welding qualification. See ASME BPVC, Section IX, Table QW/QB-422. For use in this Code, a qualified WPS is required for each strength level of material."},
            {"52", "These materials are normally microalloyed with Cb, V, and/or Ti. Supplemental specifications agreed to by manufacturer and purchaser commonly establish chemistry more restrictive-than-the-base specification, as well as plate rolling specifications and requirements for weldability (i.e., C-equivalent) and toughness."},
            {"53", "Stress relief heat treatment is required for service above 232°C (450°F)."},
            {"54", "The maximum operating temperature is arbitrarily set at 260°C (500°F) because hard temper adversely affects design stress in the creep rupture temperature ranges."},
            {"55", "Pipe produced to this specification is not intended for high temperature service. The stress values apply to any heat treatment condition, delivery condition, and service condition allowed for the applicable pipe strength level."},
            {"56", "Because of thermal instability, this material is not recommended for service above 427°C (800°F)."},
            {"57", "Conversion of carbides to graphite may occur after prolonged exposure to temperatures over 427°C (800°F). See para. F323.4(b)(2)."},
            {"58", "Conversion of carbides to graphite may occur after prolonged exposure to temperatures over 468°C (875°F). See para. F323.4(b)(3)."},
            {"59", "For temperatures above 482°C (900°F), consider the advantages of killed steel. See para. F323.4(b)(4)."},
            {"60", "Alloy 625 (UNS N06625) in the annealed condition is subject to severe loss of impact strength at room temperature after exposure in the range of 538°C to 760°C (1,000°F to 1,400°F)."},
            {"61", "Annealed at approximately 982°C (1,800°F)."},
            {"62", "Annealed at approximately 1,121°C (2,050°F)."},
            {"63", "The pipe grades listed below, marked as either or both grades in accordance with API Specification 5L, shall be considered as equivalents and treated as listed materials:\nX-Grade | L-Grade\nA25 | L175\nA | L210\nB | L245\nX42 | L290\nX46 | L320\nX52 | L360\nX56 | L390\nX60 | L415\nX65 | L450\nX70 | L485\nX80 | L555"},
            {"64", "For use under this Code, the heat treatment requirements for pipe manufactured to A671, A672, and A691 shall be as required by para. 331 for the particular material being used."},
            {"65", "For use under this Code, the designer should consider additional material requirements for flanges when the design minimum temperature is colder than -18°C (0°F). See Appendix F, para. F323.2.2(b)."}
        });

        /// <summary>
        /// Retrieves formatted note text for the given note key
        /// </summary>
        /// <param name="noteKey">Note number (e.g., "1", "2a", "4,5")</param>
        /// <returns>Formatted note text or error message if note not found</returns>
        public static string GetNote(string noteKey)
        {
            if (string.IsNullOrWhiteSpace(noteKey))
                return "No note specified";

            // Handle multiple notes separated by commas
            if (noteKey.Contains(','))
            {
                var notes = noteKey.Split(',')
                    .Select(n => n.Trim().TrimStart('(').TrimEnd(')'))
                    .Where(n => Notes.ContainsKey(n))
                    .Select(n => $"Note {n}: {Notes[n]}");

                return string.Join("\n\n", notes);
            }

            // Handle single note
            string cleanKey = noteKey.Trim().TrimStart('(').TrimEnd(')');
            if (Notes.TryGetValue(cleanKey, out var note))
                return $"Note {cleanKey}: {note}";

            return $"Note {cleanKey} not found in ASME B31.3-2024 documentation";
        }
    }
}