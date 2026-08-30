using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Controls
{
    public class ForeignKeyConverter<T> : TypeConverter where T : ICadastro, new()
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context) => true;
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) => true;

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            try
            {
                var lista = new Repository<T>().GetAll();
                var ids = lista.Select(x => x.Id).ToList();
                return new StandardValuesCollection(ids);
            }
            catch
            {
                return new StandardValuesCollection(new List<int>());
            }
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string)) return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is int id)
            {
                if (id == 0) return "(nenhum)";
                try
                {
                    var entity = new Repository<T>().GetById(id);
                    if (entity != null)
                    {
                        var str = entity.ToString();
                        if (!string.IsNullOrWhiteSpace(str) && str != id.ToString())
                            return str;
                        return entity.DisplayText ?? str ?? id.ToString();
                    }
                }
                catch { }
                return id.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string s)
            {
                s = s.Trim();
                if (s == "(nenhum)" || string.IsNullOrEmpty(s)) return 0;
                try
                {
                    var lista = new Repository<T>().GetAll();
                    var found = lista.FirstOrDefault(x =>
                        string.Equals(x.ToString()?.Trim(), s, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(x.DisplayText?.Trim(), s, StringComparison.OrdinalIgnoreCase));
                    if (found != null) return found.Id;
                }
                catch { }
                if (int.TryParse(s, out int id)) return id;
            }
            if (value is int) return value;
            return base.ConvertFrom(context, culture, value);
        }
    }
}
