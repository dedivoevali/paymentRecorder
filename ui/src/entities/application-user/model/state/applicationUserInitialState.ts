import {IApplicationUserState} from "../types/IApplicationUserState";
export const applicationUserInitialState: IApplicationUserState = {
    username: "",
    email: "",
    roles: [],
    accessToken: "",
    accessTokenExpirationDate: "",
    isAuthorized: false,
    errorMessage: "",
    isLoading: false
}