using Swapfiets.Theft.Service.Models;
using System;
using System.Collections.Generic;

namespace Swapfiets.Theft.Tests;

public static class FakeData
{
    public static readonly BikeTheftResponse BikeTheftFakes = new BikeTheftResponse(
        new List<Bike>
        {
            new Bike("description 1", new List<string>(){ "blue" }, "model", 1, null, "WBK73220IF", "stolen", true, null, "Amsterdam", null, "title", ""),
            new Bike("description 2", new List<string>(){ "blue" }, "model", 1, null, "WBK73220IE", "stolen", true, null, "Amsterdam", null, "title", ""),
            new Bike("description 3", new List<string>(){ "blue" }, "model", 1, null, "WBK73220ID", "stolen", true, null, "Amsterdam", null, "title", "")
        });

    public static readonly string BikeTheftJson = @"{
          'bikes': [
            {
              'date_stolen': 1647734259,
              'description': null,
              'frame_colors': [
                'Blue'
              ],
              'frame_model': 'xcaliber',
              'id': 1250914,
              'is_stock_img': false,
              'large_img': null,
              'location_found': null,
              'manufacturer_name': 'Trek',
              'external_id': null,
              'registry_name': null,
              'registry_url': null,
              'serial': '123',
              'status': 'stolen',
              'stolen': true,
              'stolen_coordinates': [
                52.52,
                13.4
              ],
              'stolen_location': 'Berlin, DE',
              'thumb': null,
              'title': '2022 Trek xcaliber',
              'url': 'https://bikeindex.org/bikes/1250914',
              'year': 2022
            }
          ]
        }";
}
