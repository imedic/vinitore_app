export interface Barrel {
    name: string;
    type: BarrelType;
    capacity: number;
    currentCapacity: number;
    wineName: string;
}

export interface BarrelDetail {
    name: string;
    type: BarrelType;
    capacity: number;
    currentCapacity: number;
    wineName: string;
    wineId: number;
    transfers: Transfer[];

}

export interface Transfer {

}

export interface BarrelCommand {
    name: string;
    type: BarrelType;
    capacity: number;
    currentCapacity: number;
    wineId: number;
}

export interface TransferCommand {
    
}

export enum BarrelType {
    Inox = 0,
    Wood,
    Plastic
}