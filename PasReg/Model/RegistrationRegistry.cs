﻿using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PasReg.Model
{
    public class RegistrationRegistry
    {
        private readonly string basePath;

        public RegistrationRegistry(string basePath)
        {
            this.basePath = basePath;
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }
        
        public Registration[] GetAll()
        {
            return Directory.GetFiles(basePath, "*.json")
                .Select(fileName => JsonConvert.DeserializeObject<Registration>(File.ReadAllText(fileName)))
                .ToArray();
        }

        public Registration GetOne(Guid id)
        {
            var fileName = GetRegistrationFileName(id);
            return JsonConvert.DeserializeObject<Registration>(File.ReadAllText(fileName));
        }

        public void Save(Registration registration)
        {
            if (registration.Id == null)
            {
                registration.Id = Guid.NewGuid();
            }
            
            var fileName = GetRegistrationFileName(registration.Id.Value);
            File.WriteAllText(fileName, JsonConvert.SerializeObject(registration));
        }

        public void Delete(Guid id)
        {
            File.Delete(GetRegistrationFileName(id));
        }

        private string GetRegistrationFileName(Guid id)
        {
            return Path.Combine(basePath, id + ".json");
        }
    }
}