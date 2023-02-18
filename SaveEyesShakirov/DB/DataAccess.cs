using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveEyesShakirov.DB
{
    public static class DataAccess
    {
        public static List<Agent> GetAgents()
        {
            return db.connection.Agent.ToList();
        }
        public static List<AgentType> GetAgentTypes()
        {
            return db.connection.AgentType.ToList();
        }
        public static List<Product> GetProducts()
        {
            return db.connection.Product.ToList();
        }
        public static void AddAgent(Agent agent)
        {
            db.connection.Agent.Add(agent);
            db.connection.SaveChanges();
        }
        public static void AddProduct(Product product)
        {
            db.connection.Product.Add(product);
            db.connection.SaveChanges();
        }
    }
}
