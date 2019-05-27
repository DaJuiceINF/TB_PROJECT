import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'movies', loadChildren: './pages/movies/movies.module#MoviesPageModule' },
  { path: 'movie-details', loadChildren: './pages/movie-details/movie-details.module#MovieDetailsPageModule' },
  { path: 'symptoms', loadChildren: './pages/symptoms/symptoms.module#SymptomsPageModule' },
  { path: 'home', loadChildren: './pages/home/home.module#HomePageModule' },
  { path: 'gen-info', loadChildren: './pages/gen-info/gen-info.module#GenInfoPageModule' },
  { path: 'doctorscontacts', loadChildren: './pages/doctorscontacts/doctorscontacts.module#DoctorscontactsPageModule' },
  { path: 'register', loadChildren: './pages/register/register.module#RegisterPageModule' },
];

@NgModule({ 
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
 