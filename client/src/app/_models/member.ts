import { Photo } from "./Photo";

export interface Member {
    id: number;
    userName: string;
    introduction: string;
    age: number;
    knownAs: string;
    photoUrl: string;
    created: string;
    lastActive: string;
    gender: string;
    lookingFor: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
  }
  
