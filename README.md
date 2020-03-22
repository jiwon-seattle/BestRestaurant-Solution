# Best Restaurant 

#### Restaurants in local seattle area management system, 03.18.2020

#### By **Jiwon Han**

<!-- [![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive) -->
<!-- [![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active) -->
[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/jiwon-seattle/VendorOrderTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/jiwon-seattle/VendorOrderTracker.Solution)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## 1. User Flow
  1. A user can navigate Seattle Best Restaurant in main page
  2. A user is able to add areas in Seattle and see their details
  3. A user is able to add restaurants to the area which user added in the system
  4. A user is able to see the restaurant details
  5. A user is able to manage the restaurants in areas in Seattle efficiently

<image src="./BestRestaurant\wwwroot\img/Main.png" width="500px" />

<image src="./BestRestaurant\wwwroot\img/ListofAreas.png" width="500px" />

<image src="./BestRestaurant\wwwroot\img/AddRestaurant.png" width="500px" />

## 2. Development
### Tech stack:
+ [.NET CORE](https://dotnet.microsoft.com/download/dotnet-core/) for package management
+ [MySQL](https://dev.mysql.com/downloads/file/?id=484919) 

### To run dev mode locally:
```bash
  $ git clone https://github.com/jiwon-seattle/BestRestaurant-Solution.git
  $ cd BestRestaurant
  $ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0
  $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0
  # After successfull pkg installtion
  $ dotnet run
```
Now, it will automatically open http://localhost:5000 and show you the Best Restaurant main page.

You might encounter a MySql database related errors on initial loading since this application needs a specific data route to fetch data.

## Known Bugs

There are no known bugs this time

## Support and contact details

Any feedbacks are appreciated! Please contact at email: jiwon1.han@gmail.com

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Jiwon Han_**
