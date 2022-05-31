import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import { StyleSheet, Text, View, Pressable, Image } from 'react-native';
import { Searchbar } from 'react-native-paper';
import React, { Component } from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';

const bottomTab = createBottomTabNavigator();

import Home from './main';

export default class perfil extends React.Component {
    state = {
        firstQuery: '',
    };

    render() {
        const { firstQuery } = this.state;

        const Tab = createBottomTabNavigator();

        return (

            <View style={styles.main}>
                <View style={styles.mainHeader}>
                    <View style={styles.container_header}>
                        <View style={styles.containerAR}>
                            <Text style={styles.text}>Nome completo</Text>
                        </View>

                        <View style={styles.containerData}>
                            <Text style={styles.textEmail}>usermail@pending.com</Text>
                            <Text style={styles.textCel}>+55 11 90000-0000</Text>
                        </View>
                    </View>
                </View>

                <View style={styles.containerBusiness}>
                    <View>
                        <Text style={styles.textBusiness}>Meu Negócio</Text>
                    </View>

                    <View style={styles.cardClient}>
                        <View style={styles.cardColourR} />
                        <View style={styles.mainInfoCard}>
                            <Text style={styles.key}>nome do cliente</Text>
                        </View>
                    </View>
                </View>

                <View style={styles.vector}>
                    <Image source={require('../assets/vector-original.png')} />
                </View>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#F4F4F4',
    },

    text: {
        fontSize: 23,
        fontWeight: '700',
        color: '#000',
        textTransform: 'uppercase',
    },

    mainHeader: {
        justifyContent: 'center',
        alignItems: 'center'
    },

    container_header: {
        width: '100%',
        height: 'auto',
        justifyContent: 'space-between',
    },

    containerAR: {
        marginLeft: 35,
        marginTop: 50,
    },

    vector: {
        position: 'absolute',
        height: 'auto',
        width: 'auto',
        flexDirection: 'column',
        marginTop: 30,
        justifyContent: 'center',
        alignItems: 'center',
        height: '100%',
    },

    textEmail: {
        fontSize: 13,
        color: '#999',
    },

    textCel: {
        fontSize: 13,
        color: '#999',
    },

    containerData: {
        marginLeft: 40,
    },

    containerBusiness: {
        marginLeft: 40,
        marginTop: 30,
    },

    textBusiness: {
        fontSize: 20,
        color: '#999',
    },

    cardClient: {
        width: 170,
        height: 90,
        backgroundColor: "#FDFDFD",
        flexDirection: 'row',
        alignItems: 'center',
        borderRadius: 30,
        marginBottom: 15,
        marginTop: 30,
    },

    cardColourG: {
        width: 30,
        height: 140,
        backgroundColor: '#97D5BD',
        borderBottomLeftRadius: 30,
        borderTopLeftRadius: 30,
    },

    mainInfoCard: {
        flexDirection: "column",
        marginLeft: 15,
        width: '83%',
    },
});
