"use server";
import type { AxiosRequestConfig } from "axios";
import axios from "axios";
import { BASE_URL } from "./api-constants";

// biome-ignore lint/suspicious/noExplicitAny: <explanation>
export const fetchApi = async <T,>(path: string, options: AxiosRequestConfig<any> = {}) => {
    return await axios<T>(`${BASE_URL}${path}`, {
        ...options,
        headers: {
            ...options.headers,
        },
    })
}