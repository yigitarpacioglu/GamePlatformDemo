using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GamePlatformDemo.DataAccess.Abstract;
using GamePlatformDemo.Entities.Concrete;
using MernisServiceReference;

namespace GamePlatformDemo.DataAccess.Adapters
{
    public class MernisServiceAdapter:IMemberCheckService
    {
        public bool CheckIsRealPerson(Member member)
        {
            return TaskAsync(member).Result;
        }

        public static async Task<bool> TaskAsync(Member member)
        {
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(member.TC, member.Name.ToUpper(),
                member.Lastname.ToUpper(), member.DateOfBirth.Year));
            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
